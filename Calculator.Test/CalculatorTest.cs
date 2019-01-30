using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    class CalculatorTest
    {
        private ICalculator sut;

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Calculator();
        }

        [Test]
        public void ShouldAddTwoNumbers()
        {
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    
    }
}
