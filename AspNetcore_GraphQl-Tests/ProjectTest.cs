using AspnetCore_GraphQL.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetcore_GraphQl_Tests
{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void test_Coin_Calculations()
        {
            Assert.IsTrue(CoinCalculation.Calculate(new[] { 18, 32 }, 36).SequenceEqual(new[] { 18, 18 }));

            Assert.IsTrue(CoinCalculation.Calculate(new[] { 8, 12, 24 }, 28).SequenceEqual(new[] { 12, 8, 8 }));

            Assert.IsTrue(CoinCalculation.Calculate(new[] { 11, 111 }, 232).SequenceEqual(new[] { 111, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11 }));

            Assert.IsTrue(CoinCalculation.Calculate(new[] { 72, 84, 19, 297, 192 }, 4729).SequenceEqual(new[] { 297, 297, 297, 297, 297, 297, 297, 297, 297, 297, 297, 297, 297, 297, 297, 84, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19 }));
        }
    }
}
