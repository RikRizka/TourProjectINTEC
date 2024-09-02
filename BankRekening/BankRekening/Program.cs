using BankRekening.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankRekening
{
    internal class Program
    {
        static public string fname; // di sini di gunakan static karena tidak di dalam methode
        static public string lname;
        static string address;
        static int age;
        static Bank[] banks = new Bank[2];
        static Client[] clients = new Client[2];
        static void Main(string[] args)
        {
            string line = new string('-', 50);
            Console.WriteLine(line);

            FillClietsArray();
            FillBanksArray();
            for (int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine(clients[i] + " " + banks[i]);
            }
            for (int i = 0; i < banks.Length; i++)
            {
                banks[i].Withdraw(500);
                Console.WriteLine("New saldo " + banks[i].ShowSaldo());
            }
        }

        private static void FillBanksArray()
        {
            for (int i = 0; i < banks.Length; i++)
            {
                Bank bank = InputBankInfo();
                banks[i] = banks[i];
            }
        }
       private static void FillClietsArray()
        {
            for (int i = 0; i < clients.Length; i++)
            {
                Client client = InputClienInfo();
                clients[i] = client;
            }
        }

        static void ShowInfo(Client client1, Bank bank1)
        {
            Console.WriteLine($" {client1} the saldo is: {bank1.ShowSaldo()}"); // clien here is override
        }
        static Client InputClienInfo()
        {
            Console.Clear();
            Console.Write("Enter first name please: ");
            string fname = Console.ReadLine();
            Console.Write("Enter last name please: ");
            string lname = Console.ReadLine();
            Console.Write("enter your addres please: ");
            string address = Console.ReadLine();
            Console.Write("Enter your age plase: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Client client1 = new Client(fname, lname, address, age);
            return client1;
        }
        static Bank InputBankInfo()
        {
            Console.Clear();
            Console.WriteLine("Enter your IBAN please ");
            string iban = Console.ReadLine();

            Console.WriteLine("Enter your BankName please "); 
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter Saldo: ");
            int saldo = Convert.ToInt32(Console.ReadLine());  
            
            Bank bank = new Bank(iban,bankName,saldo);
            return bank;
        }
    }
}
