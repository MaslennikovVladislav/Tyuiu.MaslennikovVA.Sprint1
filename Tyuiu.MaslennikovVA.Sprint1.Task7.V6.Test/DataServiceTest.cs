using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint1.Task7.V6.Lib;

namespace Tyuiu.MaslennikovVA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            double a = 3;
            double b = 2;
            double wait = -430.628;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}
