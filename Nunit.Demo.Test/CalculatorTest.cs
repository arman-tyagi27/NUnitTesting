using NUnit.Framework;
using System;
using Xceed.Wpf.Toolkit;

namespace Nunit.Demo.Test
{
    [TestFixture]
    public class CalculatorTest
    {

        Calculator calc;
        [SetUp]
        public void setup()
        {
            var calc = new Calculator();
        }
        [Test]
        public void Test_Addition_With_Valid_Intigers()
        {
            //var calc = new Calculator();
            var result = calc.Addition(12, 14);
            Assert.AreEqual(26, result);
        }

        [Test]
        public void Test_Subtraction_Argument_Exception()
        {
            //var calc = new Calculator();
            Assert.Catch<SystemException>(() => calc.Subtraction(10, 12));
        }

        [Test]
        public void Test_Multiplication_With_Valid_Intigers()
        {
            //var calc = new Calculator();
            var result = calc.Multiplication(10, 5);
            Assert.AreEqual(50, result);
        }

        [Test]
        public void Test_Division_With_Double()
        {
            //var calc = new Calculator();
            var result = calc.Division(12, 3);
            Assert.AreEqual(4, result);
        }

        [TestCase(2,3,5)]
        [TestCase(5, 2, 7)]
        [TestCase(5, 1, 6)]
        public void Test_Addition_Multiple(int first, int second, int expectedresult)
        {
            //var calc = new Calculator();
            var calculated = calc.Addition(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }
    }
}
