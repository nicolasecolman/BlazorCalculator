using BlazorCalculator.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorServiceTest
    {
        ICalculatorService sut = null;

        [TestInitialize]
        public void TestInitialize()
        {
            //We use the implementation for testing because we don't have a database here
            sut = new CalculatorService();
        }

        [TestMethod]
        public void Add()
        {
            var number1 = 1;
            var number2 = 1;
            var expected = 2;
            var actual = sut.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void AddOverflowException()
        {
            var number1 = int.MaxValue;
            var number2 = 1;
            var actual = sut.Add(number1, number2);
        }


        [TestMethod]
        public void Subtract()
        {
            var number1 = 1;
            var number2 = 1;
            var expected = 0;
            var actual = sut.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Multiply()
        {
            var number1 = 2;
            var number2 = 3;
            var expected = 6;
            var actual = sut.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Divide()
        {
            var number1 = 10;
            var number2 = 5;
            var expected = 2;
            var actual = sut.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivideByZero()
        {
            var number1 = 1;
            var number2 = 0;
            var actual = sut.Divide(number1, number2);

        }


    }
}
