using CalculatorMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorMVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new PropCalcu());
        }
        [HttpPost]
        public ActionResult Index(PropCalcu model, string calculate)
        {
            switch (calculate)
            {
                case "Add":
                    model.Totals = model.FirstNum + model.SecondNum;
                    break;
                case "Minus":
                    model.Totals= model.FirstNum - model.SecondNum;
                    break ;
                case "Devide":
                    model.Totals = model.FirstNum - model.SecondNum;
                    break;
                case "Multy":
                    model.Totals = model.FirstNum - model.SecondNum;
                    break;
            }
            return View(model);
        }  
    }
}
