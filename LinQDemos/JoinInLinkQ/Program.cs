﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinInLinkQ
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Buyer> buyers = new List<Buyer>()
        {
    new Buyer() { Name = "Rik", District = "Brussel", Age = 22},
    new Buyer() { Name = "Hugo", District = "Antwerpen", Age = 40},
    new Buyer() { Name = "Salvatore", District = "Brussel", Age = 30 },
    new Buyer() { Name = "Olesia", District = "Antwerpen", Age = 35 },
    new Buyer() { Name = "Zak", District = "Antwerpen", Age = 40 },
    new Buyer() { Name = "Eveliene", District = "Kortrijk", Age = 22 },
    new Buyer() { Name = "Dritan", District = "Antwerpen", Age = 30 },
    new Buyer() { Name = "Gabriela", District = "Gent", Age = 35 },
    new Buyer() { Name = "Santiago", District = "Brussel", Age = 40 }
       };
            List<Suplayer> suppliers = new List<Suplayer>()
              {
    new Suplayer() { Name = "Harrison Ford", District = "Brussel", Age = 22 },
    new Suplayer() { Name = "Charles Bronson", District = "Kortrijk", Age = 40 },
    new Suplayer() { Name = "Tina Turner", District = "Antwerpen", Age = 35 },
    new Suplayer() { Name = "Liam Neeson", District = "Brugge", Age = 30 }
              };
            var innerJoin = suppliers.Join(buyers,s => s.District, b => b.District, (s, b) => new
                {
                    SuppplierName = s.Name,
                    BuyerName = b.Name,
                    DistrictName = s.District,  
                });
            foreach (var item in innerJoin)
            {
                Console.WriteLine($" District: {item.DistrictName} Suplier: {item.SuppplierName} Buyer: {item.BuyerName}");
            }
        }
    }
}
