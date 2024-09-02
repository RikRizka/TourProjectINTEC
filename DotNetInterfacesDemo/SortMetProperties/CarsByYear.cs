using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMetProperties
{
    public class CarsByYear : IComparer<Car> //pembanding
    {
        public int Compare(Car x, Car y)
        {
            Car car1 =(Car) x;
            Car car2 =(Car) y;
            return car1.Jaar.CompareTo(car2.Jaar);
        }
    }
}
