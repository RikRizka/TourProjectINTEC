using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiK_Kort_List
{
    public class Product :IComparable<Product>,IProduct
    {
        public string Merk { get; set; }
        public string Naam { get; set; }
        public string Volume { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
            
        }
        public string GetCode()
        {
            var subString = Merk.Substring(0, 3) + Naam.Substring(0, 3) + Volume.Replace(' ', '_');
            
            return $"{subString}";
        }
        public void GetPrice() 
        { 
            
        }

        public int CompareTo(Product other)
        {
           return Price.CompareTo(other.Price);
            
        }
    }
}

       
    

