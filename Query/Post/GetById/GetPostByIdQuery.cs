using Query.Base;
using Query.Post.DTO;


namespace Query.Post.GetById
{
    public record GetPostByIdQuery(int id) : IQuery<PostDTO?>;
}
