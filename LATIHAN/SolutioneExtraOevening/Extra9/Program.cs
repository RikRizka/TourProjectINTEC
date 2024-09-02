using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Extra9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string gender;
            //penggunaka memasukan jenis kelamin dan usia jik orang tersebut ber usia 18 ke atas
            //tampilkan tuan dan nyonya

            Console.Write("How old are you ? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Are you male or female ? ");
            gender = Console.ReadLine().ToLower();

            if (gender ==  "female" &&age > 18)
            {
                Console.WriteLine("Hello Sir!");
            }
            else if (gender == "Male" && age > 18)
            {
                Console.WriteLine("Hello madam!");
            }
            else
            {
            }
            Console.WriteLine("your title is " + gender);
            {

            }


        }
    }
}
