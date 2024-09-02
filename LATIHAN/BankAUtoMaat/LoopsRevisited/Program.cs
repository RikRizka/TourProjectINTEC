using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopsRevisited
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double saldo = 1000;
            bool run = true;

            while (run)
            {
                Console.WriteLine("\nSelecteer optional :\n");
                Console.WriteLine("1. Geld storten");
                Console.WriteLine("2. Geld opvragen");
                Console.WriteLine("3. saldo");
                Console.WriteLine("4. contack opnemen met de bank");
                Console.WriteLine("5. einde\n");
                string chosen = (Console.ReadLine());
                Console.Clear();    
                switch (chosen)
                    

                {
                    case "1":
                        Console.Write("hoeveel geld wilt u storeten: ");
                        double storten = double.Parse(Console.ReadLine());
                        saldo += storten;
                        Console.WriteLine("U saldo is " + saldo);
                        break;

                    case "2":

                        Console.Write("Hoeveel geld wilt u opvragen: ");
                        double opvragen = double.Parse(Console.ReadLine());

                        if (saldo <= opvragen)

                        {
                            Console.WriteLine("Sorry uw saldo niet genoeg");
                            break;

                        }
                        else
                            saldo -= opvragen;
                        Console.WriteLine("De rest van uw geld is " + saldo );
                        Console.Write($"En je hebt {opvragen} opgevragen ");
                        break;
                    case "3":
                        Console.WriteLine("Uw saldo is: " + saldo);
                        break;

                    case "4":
                        Console.WriteLine("Contact opnemen met ons? druk Enter");
                        string vragen = Console.ReadLine();

                        Console.WriteLine("1. online contact");
                        Console.WriteLine("2. Bij de kantoor");
                        string menu = Console.ReadLine();
                        if (menu == "1")
                        {
                            Console.WriteLine("Wacht alstublieft op onze colegas's om chaten te beginen");
                            break;
                        }
                        else
                            Console.WriteLine("Ons kantoor +32234234324");
                        break;
                    default:
                        Console.WriteLine("Bendank voor u bezoek");
                        run = false;
                        break;
                         
                }
            }

        }
    }
}
