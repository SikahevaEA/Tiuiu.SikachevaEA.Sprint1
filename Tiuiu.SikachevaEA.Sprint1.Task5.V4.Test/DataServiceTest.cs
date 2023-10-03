using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint1.Task5.V4.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 25200;
            int h = 7;
            var res = ds.SecondsToHours(k);
            Assert.AreEqual(h, res);
        }
    }
}
