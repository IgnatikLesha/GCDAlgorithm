using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCDAlgorithms;


namespace GCDTest
{
    [TestClass]
    public class GCDTests
    {
        [TestMethod]
        public void GCDof2NumbersTest()
        {
            int gcd = 15;
            int a = 105; int b = 135;
            int result = GCDof2Numbers(a, b);
            Assert.AreEqual(result, gcd);
        }

        public void GCDof2NumbersTestForNegatives()
        {
            int gcd = 25;
            int a = -325; int b = -175;
            int result = GCDof2Numbers(a, b);
            Assert.AreEqual(result, gcd);
        }

        public void GCDGeneralTest()
        {
            int gcd = 15;
            int a = 105; int b = 135; int c = 30; int d = 75;
            int result = GCDGeneral(a, b, c, d);
            Assert.AreEqual(result, gcd);
        }

    }
}
