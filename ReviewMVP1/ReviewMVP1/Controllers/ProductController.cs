using Microsoft.AspNetCore.Mvc;
using ReviewMVP1.Models;

namespace ReviewMVP1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Producten()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Naam = "Apel", Prijs = 0.50m},
                new Product { Id = 2, Naam = "Brood", Prijs = 1.50m},
                new Product { Id = 3, Naam = "Kaas", Prijs = 2.50m},
                new Product { Id = 4, Naam = "Taart", Prijs = 4.50m},

            };
            Decimal totaal = products.Sum(p => p.Prijs);
            ViewBag.Totaal = totaal;
            ViewBag.Product = products;
            ViewData["ProductenLijs"] = products;
            ViewData["TotaalViewData"] = totaal.ToString();
            return View();
        }
    }
}
