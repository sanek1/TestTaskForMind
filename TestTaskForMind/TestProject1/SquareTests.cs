using LibraryCalculations;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class SquareTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BaseTest1()
        {
            //arrange
            int a = 2;
            var name = "Square";
            double expected = 12.56;

            //act
            Square s = new Square(a, name);
            var actual = Math.Truncate(100 * s.Area) / 100;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}