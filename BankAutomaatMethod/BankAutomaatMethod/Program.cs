
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutomaatMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("\nSelecteer optional :\n");
            Console.WriteLine("1. Geld storten");
            Console.WriteLine("2. Geld opvragen");
            Console.WriteLine("3. saldo");
            Console.WriteLine("4. contack opnemen met de bank");
            Console.WriteLine("5. einde\n");
            string chosen = (Console.ReadLine());
            
            Console.Clear();
            GeldStorten (1000,' ' );

          
        }
        static void GeldStorten(double saldo)
        {
            Console.Write("hoeveel geld wilt u storeten: ");
            double storten = double.Parse(Console.ReadLine());
            saldo += storten;
            Console.WriteLine("U saldo is " + saldo);

        }
        static double GeldStorten (double saldo, double storten)
        {
            Console.Write("Hoeveel geld wilt u opvragen: ");
            double opvragen = double.Parse(Console.ReadLine());

            if (saldo <= opvragen)

            {
                Console.WriteLine("Sorry uw saldo niet genoeg");
            }
            else
                saldo -= opvragen;
            Console.WriteLine("De rest van uw geld is " + saldo);
            Console.Write($"En je hebt {opvragen} opgevragen ");
            {
                return saldo;
            }

        }


    }
}
