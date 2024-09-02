using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class TestClass
    {
        public string Print() // harus void ( Ini Methode Back And)
        {
            return$"Hello world";
        }
        public string Print(string massage)
        {
            return massage;
        }
        public int CalculateAge(DateTime bornyear)
        {
            return DateTime.Now.Year - bornyear.Year;
        }
    }
}
