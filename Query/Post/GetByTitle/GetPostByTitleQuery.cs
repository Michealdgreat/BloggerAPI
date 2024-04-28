using Query.Base;
using Query.Post.DTO;


namespace Query.Post.GetByTitle
{
    public record GetPostByTitleQuery(string value) : IQuery<List<PostDTO>>;
}
