using Query.Base;
using Query.Post.DTO;

namespace Query.Post.GetAll
{
    public record GetPostListQuery : IQuery<List<PostDTO>>;
}
