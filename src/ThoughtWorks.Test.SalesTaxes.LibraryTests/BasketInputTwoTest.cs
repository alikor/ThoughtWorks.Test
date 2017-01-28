using ThoughtWorks.Test.SalesTaxes.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ThoughtWorks.Test.SalesTaxes.LibraryTests
{
    [TestClass()]
    public class BasketInputTwoTest_Given_input_two {

        Basket basket;

        [TestInitialize]
        public void Setup() {
            basket = new Basket();

            basket.Add("imported box of chocolates", 1);
            basket.Add("imported bottle of perfume", 1);
        }

        [TestMethod]
        public void Then_it_should_return_correct_tax() {
            var receipt = basket.GetReceipt();

            Assert.AreEqual(7.65M, receipt.SalesTax());
        }

        [TestMethod]
        public void Then_it_should_return_correct_totalprice() {
            var receipt = basket.GetReceipt();

            Assert.AreEqual(65.15M, receipt.TotalPrice());
        }

    }
}
