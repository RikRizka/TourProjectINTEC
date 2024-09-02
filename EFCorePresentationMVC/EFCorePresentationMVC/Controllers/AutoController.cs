using EFCorePresentationMVC.Data;
using EFCorePresentationMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCorePresentationMVC.Controllers
{
    public class AutoController : Controller
    {
        private readonly AutoContext _context;
        public AutoController(AutoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //alles inlezen
            var autos = _context.Autos.ToList();
            //record toevoegen
            _context.Autos.Add(new Auto { Merk = "Audi", Prijs = 50000 });

            return View(autos);
        }
    }
}
