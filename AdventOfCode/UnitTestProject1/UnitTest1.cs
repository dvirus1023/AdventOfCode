using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Box() { Dimensions = "2x3x4" };
            var b = new Box() { Dimensions = "1x1x10" };

            Assert.IsTrue(a.SquareFeet() == 58);
            Assert.IsTrue(b.SquareFeet() == 43);
        }
    }
}
