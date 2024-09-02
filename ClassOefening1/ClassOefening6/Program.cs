using ClassOefening6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekening rekening = new Rekening(23.5);
            Console.WriteLine(rekening);

        }
    }
}
