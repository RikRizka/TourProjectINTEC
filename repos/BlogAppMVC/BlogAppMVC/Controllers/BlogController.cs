using BlogAppMVC.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
           var blogs = await _unitOfWork.Blogs.GetAllAsync();
            return View(blogs);
        }
    }
}
