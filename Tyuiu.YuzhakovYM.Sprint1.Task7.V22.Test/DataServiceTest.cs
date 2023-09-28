using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint1.Task7.V22.Lib;

namespace Tyuiu.YuzhakovYM.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x, y;
            x = Math.PI / 4;
            y = 0;

            var res = ds.Calculate(x, y);
            double wait = 0.707;
            Assert.AreEqual(wait, res);
        }
    }
}
