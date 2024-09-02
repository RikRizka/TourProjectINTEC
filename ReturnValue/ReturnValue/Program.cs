using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValue
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int a = 5;
            int b = 10;

            await Method1(a,b);
            int result = await Method2(a,b);
            Console.WriteLine("Resultat van methid2: " + result);
        }
        static async Task Method1(int x, int y)
        {
           await Task.Delay(1000);
            Console.WriteLine($"Method1 - params {x} {y}");
        }
        static async Task<int> Method2 (int x, int y)
        {
            int result = await Method3 (x, y);    
            return result;

        }
        static async Task<int> Method3 (int x, int y)
        {
            return x + y;
        }
    }
}
