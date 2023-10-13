using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint1.Task7.V13.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double z = 0.936;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(z, res);
        }
    }
}
