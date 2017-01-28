using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public class Basket {

        Receipt receipt;
        IProductRepository productRepository;

        public Basket(IProductRepository productRepository) {
            this.receipt = new Receipt();
            this.productRepository = productRepository;
        }

        public Basket()  {
            this.receipt = new Receipt();
            this.productRepository = new ProductRepository();
        }

        public void Add(string productName, int quantity) {
            var product = productRepository.GetProduct(productName);
            receipt.AddProduct(product, quantity);
        }

        public Receipt GetReceipt() {
            return receipt;
        }

    }
}
