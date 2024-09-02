using SimpleClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Ford";
            car.Speed = 100;
            car.Name = "Mustang";
            car.Driver = "Rik";
            car.Accelerate(80);
            
            Console.WriteLine(car);
            Console.WriteLine("---------------------------");
            Console.WriteLine(car.DisplpayMassage());
            Console.WriteLine("---------------------------");
            Car bmw = new Car();
            {
                bmw.Driver = "Salvatore";
                bmw.Speed = 100;
                bmw.Make = "BMW";
                bmw.Name = "M3";
            }


            bmw.Accelerate(120);
            Console.WriteLine(bmw.DisplpayMassage());

            Car renault = new Car("Renault", 100, "Twinggo");

            Car citroen = new Car("Citroen", "C3");

            Console.WriteLine(citroen);
            Console.WriteLine(renault);







        }
    }
}
