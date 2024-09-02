using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExplained
{
    enum Months
    {
        Januarry=1,
        Februarry,
        March,
        April,
        Mei,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Months months = Months.Januarry;
            Console.WriteLine(months);

            int monthsNum=(int)months;
            Console.WriteLine(monthsNum);
            Console.WriteLine("______________________________________");

            int[]ints = (int[])Enum.GetValues(typeof(Months));//get numbers in enum

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");
            string[] strings = Enum.GetNames(typeof(Months)); // get tex in enum
            foreach(var item in strings)
            {
                Console.WriteLine(item);
            }

        }
    }
}
