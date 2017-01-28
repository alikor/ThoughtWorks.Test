using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public sealed class ProductRepository : IProductRepository {
        #region IProductFactory Members

        public Product GetProduct(string productName) {
            switch (productName) {
                case "book":
                    return new Product("book", 12.49M, ProductType.Book);
                case "music CD":
                    return new Product("music CD", 14.99M, ProductType.Other);
                case "chocolate bar":
                    return new Product("chocolate bar", 0.85M, ProductType.Food);
                case "imported box of chocolates":
                    return new Product("imported box of chocolates", 10.00M, ProductType.Food);
                case "imported box of chocolates 2":
                    return new Product("imported box of chocolates", 11.25M, ProductType.Food);
                case "imported bottle of perfume":
                    return new Product("imported bottle of perfume", 47.50M, ProductType.Other);
                case "imported bottle of perfume 2":
                    return new Product("imported bottle of perfume", 27.99M, ProductType.Other);
                case "box of chocolates":
                    return new Product("box of chocolates", 10.50M, ProductType.Other);
                case "bottle of perfume":
                    return new Product("bottle of perfume", 18.99M, ProductType.Other);
                case "packet of headache pills":
                    return new Product("packet of headache pills", 9.75M, ProductType.Medical);
                case "box of imported chocolates":
                    return new Product("box of imported chocolates", 11.25M, ProductType.Food);
            }
            return null;
        }

        #endregion
    }
}
