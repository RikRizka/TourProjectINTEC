using BlogAppMVC.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppMVC.Controllers
{
    public class PostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PostController(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(int id)
        {
           var post = await _unitOfWork.Posts.GetByIdAsync(id);
            var blog = await _unitOfWork.Blogs.GetByIdAsync(post.BlogId);
            return View( post);
            
        }
    }
}
