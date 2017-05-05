using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checking;

namespace CheckingTest
{
    [TestClass]
    public class UnitTest1
    {
        C objC;

        public UnitTest1()
        {
            objC = new C(5);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = objC.show1();
            if (result != null) Assert.AreEqual(1, result);
        }
    }
}
