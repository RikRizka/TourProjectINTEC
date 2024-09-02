using ClassLibraryCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDemos
{
    [TestFixture]

    public class FizzBuzzTetsts
    {
      
        //[TestCase(15, "FizzBuzz")]
        [TestCase(9, "Fizz")]
        //[TestCase(25, "Buzz")]
        public void ReturnFizzBuzz(int number, string expected)
        {
            string result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(expected.ToString()));
        }

    }
}
