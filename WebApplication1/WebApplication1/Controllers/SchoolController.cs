using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Klas()
        {
            return View();
        }
    }
}
