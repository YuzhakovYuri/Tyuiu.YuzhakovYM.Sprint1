using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint1.Task2.V16.Lib;

namespace Tyuiu.YuzhakovYM.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.AreEqual(12.56, res);
        }
    }
}
