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
    public class LoggerTest
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new Logger();
            logger.LogMessage("e");
            Assert.That(logger.LastError, Is.EqualTo("e"));
        }
    }
}
