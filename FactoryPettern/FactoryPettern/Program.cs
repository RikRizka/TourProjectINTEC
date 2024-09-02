using FactorryLibrarry;
using System;
using Unity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPettern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IPerson owner = Factory.CreatPerson();

            var container = new UnityContainer();

            container.RegisterType<IPerson, Person>(); //sertiap kali IPerson akan membuat new Person (Automatic)
            container.RegisterType<IWork, Work>();
            container.RegisterType<IMessageSender, SMS>();
            container.RegisterType<ILogger, LogToFile>();

            var owner = container.Resolve<IPerson>();

            owner.FirstName = "Rik";
            owner.LastName = "ALin";
            owner.EmailAddress = "Rick@gmail.com";
            owner.PhoneNumber = "1234567890";

           // IWork work = Factory.CreatWork();
           var work = container.Resolve<IWork>();

            {
                work.WorkName = "Jv Programiming";
                work.Owner = owner;
            };
            work.PerformedWork(3);
            work.PerformedWork(1.5);
            work.CompleteWork(3);
            Console.ReadLine();
        }

    }
}

