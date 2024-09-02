using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    public class Parant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"";
        }
    }
    class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;

            object[] objectArray = new object[3];
            objectArray[1] = intArray[1];
            objectArray[2] =2;
       


            Person p = new Person();
            p.Name = "John";
            p.Id = 1;
            objectArray[2] = p;

            foreach(var item in objectArray) 
            {
                if (item is  Person)
                {
                    Person person = (Person)item;
                    Console.WriteLine(person.Name + " "+ person.Id);
                }
            }

        }
    }
}
