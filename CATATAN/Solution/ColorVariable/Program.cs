using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.BackgroundColor = ConsoleColor.White;
            //    //Console.Clear(); kamu harus tau di mana kamu harus meletakan 
            //    Console.WriteLine("hello c# programers");
            //    Console.ReadLine(); 
            //#region ConsorPotiton
            //int row = 5; int col = 10; // row ke kanan kiri dan col atas bawah
            //row = row -2; col = col - 3;

            //Console.SetCursorPsition(row, col);
            //Console.WriteLine("left");
            //Console.title = "this is good"
            //#endregion

            string name = null;
            decimal salary = 0;
            bool isMale = false;

            Console.Write("Enter your name please :");
            name = Console.ReadLine();
            Console.Write("Enter ur salari :");
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("are u male?");
            isMale = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"U enetereed following salary {isMale}");

            //Decimal x;
            //int y = 0;
            //checked
            //{// jika check harus memasukan ini { dan di tutup di bawah

            //    x = (int)y;
            //    Console.WriteLine("you are losing data");
 
            //}
            //Console.WriteLine("vale of x is +y");







        }
    }
}
