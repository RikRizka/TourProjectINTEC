using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StructDemo
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public void add()
            {
                Console.WriteLine(x+y);
            }
        }
        static void Main(string[] args)
        {
            Point p = new Point() { x = 10, y = 20 }; // Object instilizerkorter kebanyakan di gunakan tapi tergantung situasi dengan ini kkita bisa banyak

            Point p1 = new Point();
            p1.x=2; 
            p1.y=5;
            p1.add();
            
            //p.x = 2;
            //p.y = 3;
            //p.add();
                
        }
    }
}
