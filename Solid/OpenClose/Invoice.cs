using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class Invoice
    {
        //tanpa private juga ini sudah menjadi private
        //Read only hampir sama dengan Constan perbedaan nya hanya cons tidak bisa di ubah tapi
        //read only hanya bisa 1x
        // di
        const int btw = 21; //selu dan tidak bisa id ubah
        public decimal SubTotal { get; set; }
        private readonly IDiscount discountStrategy;
       
        public Invoice(IDiscount discountstrategy)
        {
            this.discountStrategy = discountstrategy;
        }
        public decimal GetTotal()
        {
            return discountStrategy.ApplyDiscount(SubTotal); //ApplyDiscount dari Interface
        }
    }
}
