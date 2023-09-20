using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint1.Task1.V11.Lib;

namespace Tyuiu.YuzhakovYM.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 18;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
