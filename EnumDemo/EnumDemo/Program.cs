using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Gender
    {
        Male,
        Female,
        Unknow
    }
    class Costumer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer() { Name = "Rik", Gender=Gender.Male  };
            Costumer costumer2 = new Costumer() { Name = "Alain", Gender = Gender.Female };
            Costumer costumer3 = new Costumer() { Name = "David", Gender = Gender.  Unknow };

            List<Costumer> costumers = new List<Costumer>();
            costumers.Add(costumer1);
            costumers.Add(costumer2);
            costumers.Add(costumer3);

            foreach (Costumer costumer in costumers)
            {
                Console.WriteLine($"Name: {costumer.Name} Gender: {costumer.Gender}");
            }

        }
        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknow";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return GetGender(gender);
            }
        }
    }
}
