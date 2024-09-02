using ClassOefening2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Person person = new Person("Rik", 10);
                Console.WriteLine(person);
            }
        }
    }
}
