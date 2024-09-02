using ClassLibraryCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDemos
{
    public class DatumHulpMiddelenTest
    {
        private DatumhulpMiddelen _datumHulpMiddelen;
        [SetUp]
        public void SetUp()
        {
            _datumHulpMiddelen = new DatumhulpMiddelen();
        }
        [Test]
        public void BerekenLeeftijd_()
        {
            int result = _datumHulpMiddelen.BerekenLeeftijd(new DateTime(2001, 05, 05));
            int expected = 22;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void VoegDagenToeTest()
        {
            DateTime result = _datumHulpMiddelen.VoegDagenToe(new DateTime(2000, 05, 03), 5);
            DateTime expected = new DateTime(2000, 05, 08);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void IsWeekendTest()
        {
            bool result = _datumHulpMiddelen.IsWeekend(new DateTime(2024, 03, 09));

            bool expected = true;
            Assert.That(result, Is.EqualTo(expected));

        }
    }
}
