using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings("Hello world.."); 
            Console.ReadLine(); 
        }
        static void Greetings(string hello)
        {
            Console.WriteLine(hello);
        }
       
    
    }
}
