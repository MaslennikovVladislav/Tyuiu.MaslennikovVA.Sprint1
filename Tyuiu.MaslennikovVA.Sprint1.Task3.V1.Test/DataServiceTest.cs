using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.MaslennikovVA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 37.68;
            var res = ds.CylinderVolume(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
