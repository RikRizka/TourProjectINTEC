using ClassOefening3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rik");
            
            Console.WriteLine(person);


        }
    }
}
