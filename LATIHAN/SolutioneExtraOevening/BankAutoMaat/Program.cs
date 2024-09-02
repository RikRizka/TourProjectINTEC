using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutoMaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 1000m;
            decimal opnemenBedraag = 0;
            decimal stortenBedrag;
            string chosen;
            Console.WriteLine("wat wil je doen?");
            Console.WriteLine("1. Saldo controleren");
            Console.WriteLine("2. Geld opnemen");
            Console.WriteLine("3. Geld storten");
            Console.WriteLine("4. Stoppen");
            chosen = (Console.ReadLine());

            if (chosen == "1")
            {
                Console.WriteLine("your saldo is " + saldo);
            }
            else if (chosen == "2")
            {
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
            }
            else if (chosen == "3")
            {
                Console.WriteLine("Te storten bedrag");
                stortenBedrag = decimal.Parse(Console.ReadLine());
                saldo += stortenBedrag;
                Console.WriteLine("Je hebt nieuw saldo is" + saldo);
            }
            else if (chosen == "4") { 
            }

            {
                Console.WriteLine("Deze aplikasi is gestopt");
                Console.WriteLine("wil je deze aplikasi einde aan maken?");
                Console.WriteLine("1. ya");
                Console.WriteLine("2. Nee");
                string chossen = Console.ReadLine();
                if (chossen != "1")
                {

                }
                return;
            }


            //decimal saldo = 1000m;
            //decimal opnemenBedraag = 0;
            //decimal stortenBedrag;
            //Console.WriteLine("wat wil je doen?");
            //Console.WriteLine("1. Saldo controleren");
            //Console.WriteLine("2. Geld opnemen");
            //Console.WriteLine("3. Geld storten");
            //Console.WriteLine("4. Stoppen");
            //Console.WriteLine("5. iets anders");
            //Console.WriteLine("8. iets anders");
            //string chosen = (Console.ReadLine());
            //switch (chosen)
            //{
            //    case "1":
            //        Console.WriteLine("Switc - your saldo is " + saldo);
            //        break;
            //    case "2":
            //        Console.WriteLine("Hoeveel geld wilt u opnemen?");
            //        opnemenBedraag = decimal.Parse(Console.ReadLine());

            //        if (opnemenBedraag <= saldo)
            //        {
            //            saldo = saldo - opnemenBedraag; // cara Mudah saldo -= opnemenBedraa
            //            Console.WriteLine("je hebt " + opnemenBedraag + " opgenomen");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Onveldoende saldo");
            //        }
            //        break;                                      
            //    case "3":
            //        Console.WriteLine("Te storten bedrag");
            //        stortenBedrag = decimal.Parse(Console.ReadLine());
            //        saldo += stortenBedrag;
            //        Console.WriteLine("Jou saldo is = " + saldo);
            //        break;
            //    case "4":
            //    case "5":
            //    case "8":
            //        Console.WriteLine("Programma eindig");
            //        return;

            //    default: // seperti else
            //        Console.WriteLine("Deze aplikasi is gestopt");
            //        break;

        
        }

    }
}
