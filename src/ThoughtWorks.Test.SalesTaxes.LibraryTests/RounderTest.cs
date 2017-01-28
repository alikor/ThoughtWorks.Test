using ThoughtWorks.Test.SalesTaxes.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ThoughtWorks.Test.SalesTaxes.LibraryTests
{
    [TestClass]
    public class RounderTest {


        /// <summary>
        ///A test for Round
        ///</summary>
        [TestMethod()]
        public void When_Passed_Zero_Should_Return_Zero() {

            var result = Rounder.Round(0M);

            Assert.AreEqual(0M, result);
        }

        [TestMethod()]
        public void Rounding_Test_One_Round_up() {

            var result = Rounder.Round(1.231M);

            Assert.AreEqual(1.25M, result);
        }

        [TestMethod()]
        public void Rounding_Test_Two_Round_up() {

            var result = Rounder.Round(1.221M);

            Assert.AreEqual(1.25M, result);
        }

        [TestMethod()]
        public void Rounding_Test_Three_Should_Not_Round() {

            var result = Rounder.Round(1.25M);

            Assert.AreEqual(1.25M, result);
        }

        [TestMethod()]
        public void Rounding_Test_Four_Round_up() {

            var result = Rounder.Round(1.251M);

            Assert.AreEqual(1.30M, result);
        }
    }
}
