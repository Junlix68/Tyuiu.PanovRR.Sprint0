using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanovRR.Sprint0.Task5.V0.Lib;
namespace Tyuiu.PanovRR.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChecetAddtionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void ChecetSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void ChecetAMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void ChecetDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
