using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint1.Task2.V28.Lib;

namespace Tyuiu.MaslennikovVA.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 0;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(273, res);
        }
    }
}
