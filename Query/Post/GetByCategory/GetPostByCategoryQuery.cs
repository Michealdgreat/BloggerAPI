using Query.Base;
using Query.Post.DTO;


namespace Query.Post.GetByCategory
{
    public record GetPostByCategoryQuery(string value) : IQuery<List<PostDTO>>;
}
