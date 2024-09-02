using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindDelegate
{
    public class Formates
    {
        public static string Default(Person input)
        {
            return input.ToString();
        }
        public static string LastNametoUpper(Person input)
        {
            return input.LastName.ToUpper();
        }
        public static string FirstNameToUpper(Person input)
        {
            return input.FirstName.ToLower();
        }
        public static string FullName(Person input)
        {
            return$" {input.LastName} {input.FirstName} ";
        }
    }
}
