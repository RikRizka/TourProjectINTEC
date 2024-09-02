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
    public class ListProcessorTests
    {
        private ListProcessor _listProcessor;
        private List<String> _list;
        private List<String> _list1;
        // private  string[3];
        string[] _arr;
        [SetUp]
        public void SetUp()
        {
            _listProcessor = new ListProcessor();
            _list = new List<String> { "a", "b", "c", "a" };
            _arr = new[] { "appel", "banaan", "aardbei" };
            _list1 = new List<string> { "appel", "banaan", "citroen", "aardbei" };

        }

        [TestCase("a", new[] { "appel", "banaan", "aardbei" })]
        [TestCase("c", new[] { "citroen" })]
        [TestCase("x", new string[0])]
        public void FindStringsWithSubstring_ShouldReturnCorrectStrings(string substring,
            string[] expected)
        {
            // Act
            var result = _listProcessor.FindStringWithSubstring(_list1, substring);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
