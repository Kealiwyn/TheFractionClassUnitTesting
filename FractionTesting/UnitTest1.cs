using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FractionLib;

namespace FractionLib.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Constructor_WithZeroArguement()
        {
            //1, 2 & 3 – Constructor. You must test the three cases: creating a fraction with two ints, with one int and with no argument
            //arrange
            //declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 0, expectedBottom = 1;

            //act
            //create a fraction using the above two arguments
            Fraction f = new Fraction();

            //assert
            //compare the expectedTop with the Top property of the above object
            //compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod()]
        public void Constructor_WithOneArguements()
        {
            //arrange
            int expectedTop = 3, expectedBottom = 1;

            //act
            Fraction f = new Fraction(3);

            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod()]
        public void Constructor_WithTwoArguements()
        {
            //arrange
            int expectedTop = 3, expectedBottom = 5;

            //act
            Fraction f = new Fraction(3, 5);

            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod()]
        public void Fraction_Additions()
        {
            //arrange
            int expectedTop = 11, expectedBottom = 10;

            //act
            Fraction f = new Fraction(3, 5);
            Fraction b = new Fraction(1, 2);
            Fraction expectedResult = f + b;

            //assert
            Assert.AreEqual(expectedTop, expectedResult.Top);
            Assert.AreEqual(expectedBottom, expectedResult.Bottom);
        }

        [TestMethod()]
        public void Fraction_Subtractions_WithoutException()
        {
            //arrange
            int expectedTop = 1, expectedBottom = 10;

            //act
            Fraction f = new Fraction(3, 5);
            Fraction b = new Fraction(1, 2);
            Fraction expectedResult = f - b;

            //assert
            Assert.AreEqual(expectedTop, expectedResult.Top);
            Assert.AreEqual(expectedBottom, expectedResult.Bottom);
        }

        [TestMethod()]
        [TestCategory("WithException")]
        [ExpectedException(typeof(Exception))]
        public void Fraction_Subtractions_WithException()
        {
            //arrange
            int expectedTop = 1, expectedBottom = 10;

            //act
            Fraction b = new Fraction(1, 2);
            Fraction f = new Fraction(3, 5);

            Fraction expectedResult = b - f;

            //assert
            Assert.AreEqual(expectedTop, expectedResult.Top);
            Assert.AreEqual(expectedBottom, expectedResult.Bottom);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //arrange
            int expectedTop = 3, expectedBottom = 5;
            string expectedString = $"Your new fraction is: {expectedTop}/{expectedBottom}";

            //act
            Fraction f = new Fraction(3, 5);
            string expectedResult = f.ToString();

            //assert
            Assert.AreEqual(expectedString, expectedResult);
        }
    }
}
