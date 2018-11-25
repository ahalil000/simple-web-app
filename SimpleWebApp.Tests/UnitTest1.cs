using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleWebApp.Tests
{
    [TestClass]
    public class SimpleUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "1";
            Assert.IsTrue(s == "1");
        }
    }
}
