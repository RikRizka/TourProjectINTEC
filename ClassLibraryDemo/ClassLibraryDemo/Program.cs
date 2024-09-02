using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDemo;
using TestLibrary; //Hrus di masukan di Using TestLibrary

namespace ClassLibraryDemo
{
    internal class Program
    {
        static void Main(string[] args) // ini Methode Front And ( semua Methode CW adalah Front And)
        {
            TestClass test = new TestClass();

             //test.Print();
            Console.WriteLine(test.Print());

            //test.Print("Rik");
            Console.WriteLine(test.Print("Rik"));

            Console.WriteLine(test.CalculateAge(new DateTime(1993,10,18)));
        }
       
    }
}
