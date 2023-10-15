using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint1.Task6.V7.Lib;

namespace Tiuiu.SikachevaEA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteLastLetter()
        {
            string strTest = "123";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            string wait = "12";
            Assert.AreEqual(wait, res);

        }
    }
}
