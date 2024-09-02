using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryValidator
{
    public class Validator
    {
        public static bool IsNumber(string value)
        {
            decimal number;
            if (decimal.TryParse(value, out number))
            {
                return true;
            }
            else
            {
                Console.WriteLine("No valid input. Error");
                return false;
            }
        }
        public static bool IsInteger(string value)
        {
            int number;
            if (int.TryParse(value, out number))
            {

                return true;
            }
            else
            {
                //Console.WriteLine("This is not int. Error!");
                return false;
            }

        }
        public static bool IsNotEmpty(string value)
        {
            int number2;
            if (int.TryParse(value, out number2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsNotPositive(string value)
        {
            int number3;
            if (int.TryParse(value, out number3))
            {
                if (number3 > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsBetween(string value)
        {
            int min;
            int max;
            if (int.TryParse(value, out min) && int.TryParse(value, out max))
            
            {
                if ( max >= 20 && min <= 100)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
