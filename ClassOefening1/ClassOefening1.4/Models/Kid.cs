using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening1._4.Models
{
    public class Kid: BrithDayCake
    {
        public int Age { get; set; }
        public Kid(int numberOfCandles, int numberOfburningCandles, int age):base (numberOfCandles,numberOfburningCandles)
        {
            Age = age;
        }
        public override void LightCandle()
        {
            base.LightCandle();
        }
    }
    

}
