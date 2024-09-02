using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdubbelGetaal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int verdubble = VerdubbleGetalen(num);
            Console.WriteLine($"Het verdubble van {num} is {verdubble}");
        }
        static int VerdubbleGetalen(int num)
        {
            int verdubble = num * 2;
            return verdubble;
        }

    }
}
