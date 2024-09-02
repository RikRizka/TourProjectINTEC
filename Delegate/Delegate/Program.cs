using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        public delegate void MathDelegate(int x, int y);
        public delegate int MathDelegate1(int x, int y);// kalau return int

        static void Main(string[] args)
        {
            //Delegate sering di gunakan untuk FremWork
            // Add(2, 3);

            //Sub(10, 5);
            //Program program = new Program();
            //program.Div(5, 5);
            //program.Mul(5, 5);
            Action<int, int> del1 = new Action<int, int>(Add); //untuk Void Methode
            del1.Invoke(2,3);

            Func<int, int ,int>del2 = new Func<int, int , int>(Sub);
            var result = del2.Invoke(2,3);

       

            //Func<string, string > //Funci untuk Return selalu yang terakhir.
            
           // MathDelegate del1 = new MathDelegate(Add);
           // del1.Invoke(2, 3);
          //  del1.Invoke(3, 4);
            //MathDelegate1 del2 = new MathDelegate1(Sub);
            //var result = del2.Invoke(5, 3);
            Console.WriteLine($"The result of subtraction: {result}");

            Program program = new Program();
            Action<int , int> del3 = new Action<int, int> (program.Mul);
            //MathDelegate del3 = new MathDelegate(program.Mul);
            del3.Invoke(2, 3);

            Action<int, int> del4 = new Action<int, int> (program.Div);
           // MathDelegate del4 = new MathDelegate(program.Div);
            del4.Invoke(10, 3);

            Console.WriteLine("------------------------------------------");
            Action<int, int> del5 = del1 + del3 + del4 - del3;
           // MathDelegate del5 = del1 + del3 + del4 - del3;

            del5.Invoke(5, 5);
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is: {x + y}");
        }
        public static int Sub(int x, int y)
        {
            // Console.WriteLine($"Subtraction of {x} and {y} is: {x - y}");
            return x - y;
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is: {x * y}");
        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is: {x / y}");
        }
    }
}
