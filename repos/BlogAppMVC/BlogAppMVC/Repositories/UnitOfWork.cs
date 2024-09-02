using BlogApp.Data;
using BlogApp.Interfaces;
using BlogApp.Models;
using BlogAppMVC.Interfaces;

namespace BlogAppMVC.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public IRepository<Blog> Blogs { get; }
        public IRepository<Post> Posts { get; }

        public UnitOfWork(BlogContext context)
        {
            _context = context;
            Posts = new Repository<Post>(_context);
            Blogs = new Repository<Blog>(_context);
        }


        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
