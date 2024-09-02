using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening1._4.Models
{
    public class BrithDayCake
    {
        public int NumberOfCandles { get; set; }
        public int NumberOfburningCandles { get; set; }

        public BrithDayCake(int numberOfCandles,int numberOfburningCandles)
        {
            NumberOfCandles = numberOfCandles;
            NumberOfburningCandles = numberOfburningCandles;
        }
        public BrithDayCake(int ic)
        {

        }
        public virtual void LightCandle()
        {
             NumberOfburningCandles++;
        }
        public virtual void BlowOutCandel() 
        {
            NumberOfCandles--;
        }
        public int GetNumberOfCandles ()
        {
            return NumberOfCandles = 0;
        }
        public int GetnumberOfBurningCandles(int numberOfBurningCandles)
        {
            return numberOfBurningCandles = 0;
        }


    }
}
