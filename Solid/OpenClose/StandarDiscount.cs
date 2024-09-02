using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class StandarDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal subtotal)
        {
            return subtotal - (subtotal * 0.05m);//5% discount
        }
    }
}
