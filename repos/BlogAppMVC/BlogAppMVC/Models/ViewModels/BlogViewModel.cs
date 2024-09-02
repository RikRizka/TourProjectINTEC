using BlogApp.Models;

namespace BlogAppMVC.Models.BlogViewModels
{
    public class BlogViewModel
    {
        public Blog Blog { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
