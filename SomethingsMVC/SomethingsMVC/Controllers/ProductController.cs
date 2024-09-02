using Microsoft.AspNetCore.Mvc;
using SomethingsMVC.Models;

namespace SomethingsMVC.Controllers
{

    public class ProductController : Controller
    {

        [HttpGet]
        public IActionResult Index(Product product)
        {

            var coll = product.GetProducts();
            ViewBag.Total = product.Calculate();
            return View(coll);
        }




    }
}
