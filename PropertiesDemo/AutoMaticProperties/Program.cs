using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoMaticProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(18);
            p.Name = "rik";
            p.Age = 25;
            Console.WriteLine(p.Name);

        }
    }
}
