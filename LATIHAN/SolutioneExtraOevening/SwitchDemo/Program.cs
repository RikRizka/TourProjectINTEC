using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 1000m;
            decimal opnemenBedraag = 0;
            decimal stortenBedrag;
            Console.WriteLine("wat wil je doen?");
            Console.WriteLine("1. Saldo controleren");
            Console.WriteLine("2. Geld opnemen");
            Console.WriteLine("3. Geld storten");
            Console.WriteLine("4. Stoppen");
            Console.WriteLine("5. iets anders");
            Console.WriteLine("8. iets anders");
            string chosen = (Console.ReadLine());
            switch (chosen)
            {
                case "1":
                    Console.WriteLine("Switc - your saldo is " + saldo);
                    break;
                    case "2":
                    Console.WriteLine("Hoeveel geld wilt u opnemen?");
                    opnemenBedraag = decimal.Parse(Console.ReadLine());

                    if (opnemenBedraag <= saldo)
                    {
                        saldo = saldo - opnemenBedraag;
                        Console.WriteLine("je hebt " + opnemenBedraag + " opgenomen");
                    }
                    else
                    {
                        Console.WriteLine("Onveldoende saldo");
                    }
                    break;
                    case "3":
                    Console.WriteLine("Te storten bedrag");
                    stortenBedrag = decimal.Parse(Console.ReadLine());
                    saldo += stortenBedrag;
                    Console.WriteLine("Jou saldo is = " + saldo);
                    break; 
                    case "4":
                    case "5":
                    case "8":
                    Console.WriteLine("Programma eindig");
                    return;

                    default: // seperti else
                    Console.WriteLine("Deze aplikasi is gestopt");
                    break;
            }
        }
    }
}
