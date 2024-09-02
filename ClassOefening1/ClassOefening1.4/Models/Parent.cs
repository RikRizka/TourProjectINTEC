using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening1._4.Models
{
    public class Parent:BrithDayCake
    {
       
        public override void LightAllCandles()
        {
            base.LightCandle();
            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
}
