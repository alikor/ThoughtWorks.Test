using ThoughtWorks.Test.SalesTaxes.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ThoughtWorks.Test.SalesTaxes.LibraryTests
{
    [TestClass()]
    public class BasketInputThreeTest_Given_input_Three {

        Basket basket;

        [TestInitialize]
        public void Setup() {
            basket = new Basket();

            basket.Add("imported bottle of perfume 2", 1);
            basket.Add("bottle of perfume", 1);
            basket.Add("packet of headache pills", 1);
            basket.Add("imported box of chocolates 2", 1);
        }

        [TestMethod]
        public void Then_it_should_return_correct_tax() {
            var receipt = basket.GetReceipt();

            Assert.AreEqual(6.70M, receipt.SalesTax());
        }

        [TestMethod]
        public void Then_it_should_return_correct_totalprice() {
            var receipt = basket.GetReceipt();

            Assert.AreEqual(74.68M, receipt.TotalPrice());
        }

    }
}
