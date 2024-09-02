using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList(2);
            myList.Add(1);
            Console.WriteLine( myList);
        }
    }
}
