﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint1.Task2.V16.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 25;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.AreEqual(157, res);
        }
    }
}
