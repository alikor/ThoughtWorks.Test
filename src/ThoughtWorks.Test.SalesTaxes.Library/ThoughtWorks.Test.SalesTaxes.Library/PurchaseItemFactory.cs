using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public sealed class PurchaseItemFactory : IPurchaseItemFactory {

        ProductType exceptProductTypes;

        #region IPurchaseItemFactory Members

        public PurchaseItemFactory() {
            exceptProductTypes = ProductType.Food | ProductType.Book | ProductType.Medical;
        }

        public PurchaseItem GetPurchaseItem(Product product, int quantity) {
            var purchaseItem = new PurchaseItem(product, quantity);

            if ((product.ProductType & exceptProductTypes) != product.ProductType ) {
                purchaseItem = new BasicSalesTaxedPurchaseItem(purchaseItem);
            }

            if (purchaseItem.Product.Name.Contains("imported")) {
                purchaseItem = new ImportedTaxedPurchaseItem(purchaseItem);
            }

            return purchaseItem;
        }

        #endregion
    }
}
