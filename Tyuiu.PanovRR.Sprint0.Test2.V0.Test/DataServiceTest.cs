using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PanovRR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PanovRR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Роман";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Роман", res);
        }
    }
}
