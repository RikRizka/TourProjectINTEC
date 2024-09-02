using Microsoft.AspNetCore.Mvc;
using TestenMVC.Models;

namespace TestenMVC.Controllers
{
    public class StrongController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Product product = new Product();

            return View(product);
        }
    }
}
