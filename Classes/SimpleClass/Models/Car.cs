using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass.Models
{
    public class Car
    {
        public string Make;
        public int Speed;
        public string Name;

        public string Driver;
        
        public Car() 
        {
            
        }
        public Car (string make, int speed, string name,string driver)
        {
            Make = make;
            Speed = speed;
            Name = name;



        }
        public Car (String make, string name)
        {
            Make = make;
            Speed = 100;
            Name = name;
        }
        public void Accelerate(int speed) // kalau +10 maka int speed di hilangkan
        {
            //Speed = speed;
            speed += 10;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Speed {Speed}, Name: {Name}";
        }
        public string DisplpayMassage()
        {
            return $"{Driver} is driving {Make} and the speed {Speed}";
        }
    }
}
