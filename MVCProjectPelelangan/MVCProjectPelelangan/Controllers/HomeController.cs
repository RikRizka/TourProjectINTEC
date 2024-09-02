using Microsoft.AspNetCore.Mvc;
using MVCProjectPelelangan.Models;
using System.Diagnostics;

namespace MVCProjectPelelangan.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        // {
        //     return "Welcom .Net";
        // }
        public ActionResult Index() 
        { 
            //Logic dinamic output
            int hours = DateTime.Now.Hour;
            string costumer = " My Costumer";
            if (6 < hours & hours < 12)
                ViewBag.Welcome = "Good morning" + costumer;
            else if (12 > hours & hours < 18)
            {
                ViewBag.Welcome = "Good Afternoon" + costumer;
          
            }
            else
            {
                ViewBag.Welcome = "Good night" + costumer;
            }
            
            return View(); 
        }
        public ActionResult FormAuction(ResponsCostumers responsCostumers) 
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", responsCostumers);
            }
         
                return View();
            
           
        }
    }
}
