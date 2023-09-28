using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint1.Task6.V1.Lib;

namespace Tyuiu.YuzhakovYM.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "a";
            DataService ds = new DataService();
            string res = ds.SymbolCode(strTest);
            string wait = "97";
            Assert.AreEqual(wait, res);
        }
    }
}
