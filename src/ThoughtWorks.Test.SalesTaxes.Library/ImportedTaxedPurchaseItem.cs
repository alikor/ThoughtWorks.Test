using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public sealed class ImportedTaxedPurchaseItem : PurchaseItem {
        private PurchaseItem item;

        public ImportedTaxedPurchaseItem(PurchaseItem item) {
            this.item = item;
        }

        public override decimal SalesTax {
            get {
                return item.SalesTax + Rounder.Round( ((item.Product.Price * 5) / 100) );
            }
        }

        public override decimal Price {
            get {
                return (item.Price - item.SalesTax) + this.SalesTax;
            }
        }

        public override int Quantity {
            get {
                return item.Quantity;
            }
            set {
                item.Quantity = value;
            }
        }

        public override Product Product {
            get {
                return item.Product;
            }
        }
    }
}
