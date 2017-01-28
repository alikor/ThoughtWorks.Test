using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public interface IProductRepository {
        Product GetProduct(string ProductName);
    }
}
