using BlogApp.Models;

namespace BlogApp.Interfaces
{
    public interface IPost : IRepository <Post>
    {
      Task<List<Post>> GetAllPosts();
    }
}
