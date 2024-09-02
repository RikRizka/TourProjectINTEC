using Microsoft.AspNetCore.Mvc;

namespace CalculatorMVPProject.Controllers
{
    public class CalcuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
