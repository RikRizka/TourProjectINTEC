using FactorryLibrarry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPettern
{
    internal static class Factory
    {
        public static IPerson CreatPerson()
        {
            return new Person();
        }   
        public static IWork CreatWork()
        {
            return new  Work(CreateLogger(), CreateMessageSender());
        }
        public static ILogger CreateLogger() 
        {
            return new LogToFile();
          //  return new Logger();
        }
        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }
        //public static IMessageSender CreateSMS()
        //{
        //    return new SMS();
        //}

    }
}
