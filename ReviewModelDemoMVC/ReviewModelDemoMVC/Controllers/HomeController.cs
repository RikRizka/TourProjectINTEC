using Microsoft.AspNetCore.Mvc;
using ReviewModelDemoMVC.Models;
using ReviewModelDemoMVC.Models.ViewModels;
using System.Diagnostics;

namespace ReviewModelDemoMVC.Controllers
{
    public class HomeController : Controller
    {
   
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            products.Add(new Product { Id = 2, Name = "TV", Price = 1000 });
            products.Add(new Product { Id = 3, Name = "Smartphone", Price = 1000 });

            List<Suplay> suplays = new List<Suplay>();
            suplays.Add(new Suplay { Id = 1, Name = "Dell"});
            suplays.Add(new Suplay { Id = 2, Name = "Samsung"});
            suplays.Add(new Suplay { Id = 3, Name = "Apple"});


            var viewModel = new ProductSuplayViewModel
            {
                Products = products,
                Suplays = suplays
            };
            return View(viewModel);
        }

       

      
    }
}
