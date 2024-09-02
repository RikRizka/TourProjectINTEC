using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMenagement.Models
{
    public static class Helpers
    {
        public static string Lijn(int length)
        {
            return $"{new string ('-', 50)}";
        }
    }
}
