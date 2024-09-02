using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    public class Garage : IEnumerable<Car>
    {
        private Car[] carArray = new Car[4]; //Container
        public Garage()
        {
            carArray[0] = new Car { Name = "BMW" };
            carArray[1] = new Car { Name = "Ford" };
            carArray[2] = new Car { Name = "Volvo" };
            carArray[3] = new Car { Name = "Toyota" };
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return ((IEnumerable<Car>)carArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return carArray.GetEnumerator();
        }
    }
}
