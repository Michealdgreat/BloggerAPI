using Application.Post.CreatePost;
using Application.Post.DeletePost;
using Application.Post.UpdatePost;
using Query.Post.DTO;
using Query.Post.GetByCategory;
using Query.Post.GetById;
using Query.Post.GetByTitle;

namespace PresentationFacade.Post
{
    public interface IPostFacade
    {
        Task CreatePost(CreatePostCommand command);
        Task DeletePost(DeletePostCommand command);
        Task<List<PostDTO>> GetAllPosts();
        Task<List<PostDTO>> GetPostByCategory(string query);
        Task<PostDTO?> GetPostById(int query);
        Task<List<PostDTO>> GetPostByTitle(string query);
        Task UpdatePost(UpdatePostCommand command);
    }
}