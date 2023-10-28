using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.SprintReview1.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.SprintReview1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double res = dt.Calculate(12.23, 3.21);
            Assert.AreEqual(res, 0,123);
        }
    }
}
