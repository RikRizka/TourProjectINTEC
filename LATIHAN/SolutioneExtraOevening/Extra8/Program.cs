using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Extra8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Minta pengguna memasukan hari dalam seminggu
            //misal nya senin selasa dts..
            //tunjukan apakah itu hari kerja atau tidak

            //Console.Write("What day is today ? ");
            //string day= Console.ReadLine();

            //if (day == "saturday" && day == "sunday")
            //{
            //    Console.WriteLine("Today is weekand");
            //}
            //else
            //{
            //    Console.WriteLine("Today is working day ");
            //}
            Console.Write("Enter a day :");
            string putday = Console.ReadLine();
           // string dayName = "";
            switch (putday.ToLower())
               
            {
                case "saturday":
                   putday  = "saturday";
                    Console.WriteLine("today is day off");
                    break;

                case "Sunday":
                    putday = "sunday";
                    break;
                    default:
                    Console.WriteLine($"Today is a working day{putday}");
                    break;


                
            }
            

        }
    }
}
