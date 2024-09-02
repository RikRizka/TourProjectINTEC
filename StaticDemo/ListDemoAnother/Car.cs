using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemoAnother
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        
        public override string ToString()
        {
            return $"{Year.ToString().PadRight(15)} {Make.PadRight(15)} {Color.PadRight(15)} {Price.ToString().PadRight(15)} ";
        }
    }
}
