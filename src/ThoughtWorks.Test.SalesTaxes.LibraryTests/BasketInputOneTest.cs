using ThoughtWorks.Test.SalesTaxes.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ThoughtWorks.Test.SalesTaxes.LibraryTests
{
    [TestClass()]
    public class BasketInputOneTest_Given_input_one {

        Basket basket;

        [TestInitialize]
        public void Setup() {
            basket = new Basket();

            basket.Add("book", 1);
            basket.Add("music CD", 1);
            basket.Add("chocolate bar", 1);
        }

        [TestMethod]
        public void Then_it_should_return_correct_tax() {
            var receipt = basket.GetReceipt();
            Assert.AreEqual(1.50M, receipt.SalesTax());
        }

        [TestMethod]
        public void Then_it_should_return_correct_totalprice() {
            var receipt = basket.GetReceipt();

            Assert.AreEqual(29.83M, receipt.TotalPrice());
        }

    }
}
