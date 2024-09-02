using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreateTreath
{
    class Swither
    {
        public void Write0()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("0");
                Thread.Sleep(5);
            }
        }
        public void Write1()
        {
           for (int i = 0; i < 100; i++)
            {
                Console.Write("1");
                Thread.Sleep(5);
            }
       
        }
        public void Switch()
        {
            Thread thread = new Thread(Write0);
            thread.Start();
            Write1();
        }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Swither s = new Swither();
            Thread thread1 = new Thread(s.Write0);
            Thread thread2 = new Thread(s.Write1);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Done");


        }
    }
}
