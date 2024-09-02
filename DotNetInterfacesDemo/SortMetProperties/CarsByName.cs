using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMetProperties
{
    public class CarsByName : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            Car car1 = (Car)x;
            Car car2 = (Car)y;

            return string.Compare(car1.Naam, car2.Naam, StringComparison.OrdinalIgnoreCase);//untuk ignore huruf besar dan kecil
        }

        //public int CompareTo(Car other)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
