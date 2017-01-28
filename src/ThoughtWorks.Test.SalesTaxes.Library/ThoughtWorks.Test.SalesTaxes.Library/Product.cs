using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public sealed class Product {

        public Product(string name, decimal price, ProductType productType) {
            this.Name = name;
            this.Price = price;
            this.ProductType = productType;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public ProductType ProductType { get; private set; }
    }
}
