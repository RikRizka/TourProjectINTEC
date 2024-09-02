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
    public class TekstHelperTest
    {
        private TeksHelper _tekstHelper;
        [SetUp]
        public void SetUp()
        {
            _tekstHelper = new TeksHelper();
        }
        [Test]
        public void Lenget_GegevenString_ReturneertLengte()
        {
            int lengte = _tekstHelper.Lengte("Reem");
            Assert.That(lengte, Is.EqualTo(4));
        }
        [Test]
        public void Omkeren_GegevenString_ReturnOmgekeerde()
        {
            // Arrange
            // string worden = "Reem";
            //Act
            string result = _tekstHelper.Omkeren("Reem");
            string expected = "meeR";
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void NaarHoofdletters_GegevenString_ReturnGrooteLetter()
        {
            // Arrange
            // string worden = "reem";
            //Act
            string result = _tekstHelper.NaarHoofdletters("reem");
            string expected = "REEM";
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void IsLeeg_GegevenString_RetourneertTrue()
        {
            bool result = _tekstHelper.IsLeeg("");
            bool expected = true;

            Assert.That(result, Is.EqualTo(expected));
        }
        // [Ingore("Because I just want it")]
        [Test]
        public void Samenvoegen_GegevenTweeString_RetourneertSamengevoegdeSamen()
        {
            string result = _tekstHelper.Samenvoegen("Reem", "Alawad");
            string expected = "ReemAlawad";

            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(10, "Positief")]
        [TestCase(-1, "Negatief")]
        [TestCase(0, "Null")]
        public void Analyze_ShouldIdentifyNumberCorrectly(int number, string expeted)
        {
            string result = _tekstHelper.Analyze(number);


            Assert.That(result, Is.EqualTo(expeted));
        }
    }
}
