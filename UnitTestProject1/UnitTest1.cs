using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Calcuator calc =  new Calcuator();

            // arrange
            double x = 5.6;
            double y = 3.2;
            double expected = 8.8;
            
            // act
           double  result = calc.Addition(x, y);

            // assert

            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            Calcuator calc = new Calcuator();

            // arrange
            double x = 6.4;
            double y = 4.2;
            double expected = 2.2;

            // act
            double result = calc.Substraction(x, y);

            // assert

            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            Calcuator calc = new Calcuator();

            // arrange
            double x = 6.0;
            double y = 4.2;
            double expected = 25.2;

            // act
            double result = (calc.Multiplication(x, y));

            // assert

            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestDivision()
        {
            Calcuator calc = new Calcuator();

            // arrange
            double x = 6.8;
            double y = 4.2;
            double expected = 1.6;

            // act
            double result = calc.Division(x, y);

            // assert

            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestModulos()
        {
            Calcuator calc = new Calcuator();

            // arrange
            double x = 6.0;
            double y = 4.0;
            double expected = 2;

            // act
            double result = calc.Modulos(x, y);

            // assert

            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestIsNegativeNumber()
        {
            PrivateObject cal = new PrivateObject(typeof(Calcuator));
            Calcuator calc = new Calcuator();

            // arrange
            double x = -6.0;
            bool expected = true;
           


            // act
              bool result =Convert.ToBoolean( cal.Invoke("IsNegative", x));

            // assert

            Assert.AreEqual(result, expected);
        }
    }
}
