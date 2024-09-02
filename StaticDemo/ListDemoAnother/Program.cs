using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ListDemoAnother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car car1 = new Car() { Make = "Citroen", Year = 2010, Color = "Yello", Price = 35000.00m };
            Car car2 = new Car() { Make = "Renault", Year = 2011, Color = "Red", Price = 36000.00m };
            Car car3 = new Car() { Make = "BMW", Year = 2012, Color = "Black", Price = 37000.00m };
            Car car4 = new Car() { Make = "Toyota", Year = 2013, Color = "Pink", Price = 38000.00m };

            string header = Helper.GenerateHeader(); //public static untuk bisa mem
          
            List<Car> list = new List<Car>() { car1, car2, car3, car4 };
            string lijn = new string('-', header.Length + 1);

            Console.WriteLine(lijn);
            Console.WriteLine(header);
            Console.WriteLine(lijn);
            decimal total = 0;


            foreach (Car item in list)
            {
                total += item.Price;
                Console.WriteLine(item);
            }
           Console.WriteLine(lijn);
           Console.WriteLine(Helper.TotalString);

            string footer = Helper.GenerateFooter(total, lijn);
            Console.WriteLine(footer);
            Console.WriteLine(lijn);
        }
    }
}
