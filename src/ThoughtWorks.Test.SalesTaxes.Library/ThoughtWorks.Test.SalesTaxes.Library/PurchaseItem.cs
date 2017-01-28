using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public class PurchaseItem {
        private int quantity;
        public virtual Product Product { get; private set; }

        public PurchaseItem() {
        }

        public PurchaseItem(Product product, int quantity) {
            this.Product = product;
            this.Quantity = quantity;
        }

        public virtual decimal Price 
        {
            get {
                return this.Quantity * Product.Price;
            }
        }
        public virtual decimal SalesTax { 
            get {
                return 0M;
            }
        }
        public virtual int Quantity {
            get { return this.quantity; }
            set 
            {
                if (value <= 0) {
                    quantity = 0;
                }
                quantity = value;
            }
        }
    }


}
