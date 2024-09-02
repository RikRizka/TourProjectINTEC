using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMenagement.Models
{
    public class Winkel
    {
        private List<Product> _producten;

        public Winkel()
        {
            _producten = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _producten.Add(product); // di masukan pada produc di list
        }
        public void ToonVoorraad()
        {
            foreach (var product in _producten)
            {
                Console.WriteLine(product);

            }
        }
        public void VerwijderProduct(string name)
        {
            for (int i = 0; i < _producten.Count; i++)
            {
                if (_producten[i].Name == name)
                {
                    _producten.RemoveAt(i);
                }
            }
        }
        public void UpdateProduct(string name, string newProducName)
        {          
            for (int i = 0; i < _producten.Count; i++)
            {
                if (_producten[i].Name == name)
                {
                    _producten[i].Name = newProducName;
                }
               
            }                
        }
        public void UpdateProduct(string name, string newProducName, double newPrijs)
        {
            for (int i = 0; i < _producten.Count; i++)
            {
                if (_producten[i].Name == name)
                {
                    _producten[i].Name = newProducName;
                    _producten[i].Name = 

                }

            }
        }
    }
}



    

