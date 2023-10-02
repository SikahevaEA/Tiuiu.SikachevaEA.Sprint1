using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint1.Task3.V5.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 7;
            int r = 35;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(r, res);

        }
    }
}
