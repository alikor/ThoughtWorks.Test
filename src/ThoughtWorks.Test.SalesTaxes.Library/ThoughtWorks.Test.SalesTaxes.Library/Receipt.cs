using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public sealed class Receipt {

        private readonly IPurchaseItemFactory purchaseItemFactory;

        public IList<PurchaseItem> Items { get; set; }

        public Receipt(IPurchaseItemFactory purchaseItemFactory) {
            this.Items = new List<PurchaseItem>();
            this.purchaseItemFactory = purchaseItemFactory;
        }

        public Receipt()  {
            this.Items = new List<PurchaseItem>();
            this.purchaseItemFactory = new PurchaseItemFactory(); ;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items) {
                sb.Append(item.Quantity).Append(" ").Append(item.Product.Name).Append(": ").Append(Rounder.Round(item.Price).ToString("N2")).Append(" ");
            }
            sb.Append("Sales Taxes: ").Append(this.SalesTax().ToString("N2") ).Append(" Total: ").Append(this.TotalPrice().ToString("N2") );
            return sb.ToString();
        }

        public void AddProduct(Product product, int quantity){
            var item = this.purchaseItemFactory.GetPurchaseItem(product, quantity);
            this.Items.Add(item);
        }


        public decimal TotalPrice() {
            return this.Items.Sum(x => x.Price);
        }

        public decimal SalesTax() {
            return this.Items.Sum(x => x.SalesTax);
        }
    }
}
