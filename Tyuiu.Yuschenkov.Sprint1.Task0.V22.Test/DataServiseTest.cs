using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Yuschenkov.Sprint1.Task0.V22.lib;

namespace Tyuiu.Yuschenkov.Sprint1.Task0.V22.test
{
    [TestClass]
    public class DateServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateServise ds = new DateServise();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
