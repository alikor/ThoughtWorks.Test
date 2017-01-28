using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public interface IPurchaseItemFactory {
        PurchaseItem GetPurchaseItem(Product product, int quantity);
    }
}
