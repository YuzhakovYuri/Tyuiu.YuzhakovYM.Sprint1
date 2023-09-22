using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint1.Task3.V17.Lib;

namespace Tyuiu.YuzhakovYM.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.013;
            bool wait = true;
            var res = ds.ZeroCheck(x);
            Assert.AreEqual(wait, res);
        }
    }
}
