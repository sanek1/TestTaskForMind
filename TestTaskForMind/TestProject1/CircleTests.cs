using LibraryCalculations;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BaseTest()
        {
            //arrange
            int a = 2;
            var name = "Circle";
            double expected = 12.56;

            //act
            Circle s = new Circle(a, name);
            var actual = Math.Truncate(100 * s.Area) / 100;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}