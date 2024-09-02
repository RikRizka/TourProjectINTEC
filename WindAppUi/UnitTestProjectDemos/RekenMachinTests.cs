using ClassLibraryCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDemos
{
    [TestFixture]
    public class RekenMachinTests
    {
        private RekenMachin _rekenMachin;

        [SetUp]
        public void SetUp()
        {
            _rekenMachin = new RekenMachin();
        }

        [Test]
        public void Add_GegevenTweeGetallen_ReturnSum()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act 
            int result = _rekenMachin.Add(a, b);
            int expected = 3;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Sub_GegevenTweeGetallen_ReturnVerschil()
        {
            // Arrange
            int a = 2;
            int b = 1;

            // Act 
            int result = _rekenMachin.Sub(a, b);
            int expected = 1;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Mult_GegevenTweeGetallen_ReturnProduct()
        {
            // Arrange
            int a = 2;
            int b = 1;

            // Act 
            int result = _rekenMachin.Mult(a, b);
            int expected = 2;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Div_GegevenTweeGetallen_ReturnDivision()
        {
            // Arrange
            int a = 2;
            int b = 1;

            // Act 
            int result = _rekenMachin.Div(a, b);
            int expected = 2;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Delen_OpNull_Divident0()
        {
            // Arrange
            int a = 2;
            int b = 0;
            //Assert
            Assert.Throws<DivideByZeroException>(() => _rekenMachin.Div(a, b));
        }

        [TestCase(0, false)]
        [TestCase(1, true)]
        [TestCase(50, true)]
        [TestCase(101, false)]
        [TestCase(-1, false)]
        [TestCase(1000, false)]
        public void IsInRange_ShouldValidateCorrectRange(int number, bool expeted)
        {
            //Act
            bool result = _rekenMachin.IsInRange(number);
            //Assert
            Assert.That(expeted, Is.EqualTo(result));
        }

    }
}
