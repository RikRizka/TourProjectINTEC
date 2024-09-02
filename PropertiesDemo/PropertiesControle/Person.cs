using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesControle
{
    public class Person
    {
        public string Name { get; set; }
        private int _leeftijd;

        public int Leeftijd
        {
            set
            {
                if(value < 18)
                {
                    Console.WriteLine("gij bent te jong");
                }
                else
                {
                    _leeftijd = value;
                    Console.WriteLine("U bent welcome");
                }
              
            }

        }
    }
}
