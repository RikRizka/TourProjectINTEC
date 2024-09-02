using BlogApp.Interfaces;
using BlogApp.Models;

namespace BlogAppMVC.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository <Blog> Blogs { get; }
        IRepository<Post> Posts { get; }
        Task<int> CompleteAsync();
    }

}
