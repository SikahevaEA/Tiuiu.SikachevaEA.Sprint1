using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint1.Task4.V13.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double rez = 0.001;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(rez, res);
        }
    }
}
