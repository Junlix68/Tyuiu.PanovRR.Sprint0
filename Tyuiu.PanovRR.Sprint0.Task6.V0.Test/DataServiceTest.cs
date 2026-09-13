using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanovRR.Sprint0.Task6.V0.Lib;
namespace Tyuiu.PanovRR.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChexkAdditionArrayValid()
        {
            var numbrs = new int[] {1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(numbrs);
            Assert.AreEqual(15, res);
        }
        public void ChexkASubtractionArrayValid()
        {
            var numbrs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbrs);
            Assert.AreEqual(-15, res);
        }
        public void ChexkMultiplicationArrayValid()
        {
            var numbrs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbrs);
            Assert.AreEqual(120, res);
        }
    }
}
