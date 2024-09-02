using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestenNum3
{

    internal class Program
    {
        static void Main(string[] args)
        {

            decimal snupjesPrice = 0.42m;
            decimal paymentAmount = 2m;
            decimal refund;

            if (snupjesPrice < 0.30m || snupjesPrice > 1.20m)
            {
                Console.WriteLine("sorry de cos have to be between 0.30 and 1.20");
            }
            else if(paymentAmount < snupjesPrice) 
            {
                Console.WriteLine("your money is not enought");
            }
            else
            {
                refund = paymentAmount - snupjesPrice;
                Console.WriteLine("refund = " + refund);   
            }
             
            











        }
    }
}
