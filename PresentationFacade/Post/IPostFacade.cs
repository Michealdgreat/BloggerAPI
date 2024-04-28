using Application.Post.CreatePost;
using Application.Post.DeletePost;
using Application.Post.UpdatePost;
using Domain.PostDomain;
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
        Task<List<PostDTO>> GetPostByCategory(GetPostByCategoryQuery query);
        Task<PostDTO?> GetPostById(GetPostByIdQuery query);
        Task<List<PostDTO>> GetPostByTitle(GetPostByTitleQuery query);
        Task UpdatePost(UpdatePostCommand command);
    }
}