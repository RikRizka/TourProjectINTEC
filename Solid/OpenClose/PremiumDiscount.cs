using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class PremiumDiscount : IDiscount
    {
        DateTime vandaag;
        public PremiumDiscount()
        {
            vandaag = DateTime.Now.AddDays(1);
        }
        public decimal ApplyDiscount(decimal subtotal)
        {
            if (IsJanuaryOfFebruary(vandaag))
            {
                return subtotal - (subtotal * 0.20m);//20% korting
            }
            else
            {
                return subtotal - (subtotal * 0.10m);//10%
            }

        }
        public bool IsJanuaryOfFebruary(DateTime vandaag)
        {
            if (vandaag.Month == 1 || vandaag.Month == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
