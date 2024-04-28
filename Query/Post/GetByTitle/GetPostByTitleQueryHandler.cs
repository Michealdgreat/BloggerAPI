using Infrastructure.DataAccess;
using Query.Base;
using Query.Post.DTO;

namespace Query.Post.GetByTitle
{
    public class GetPostByTitleQueryHandler(IRepositoryBase repositoryBase) : IQueryHandler<GetPostByTitleQuery, List<PostDTO>>
    {
        private readonly IRepositoryBase _repoBase = repositoryBase;

        public async Task<List<PostDTO>> Handle(GetPostByTitleQuery request, CancellationToken cancellationToken)
        {
            var result = await _repoBase.FromDataBase<PostDTO, dynamic>("dbo.GetPostsByTitle", new { @Title = request.value }, "BloggerConnStrings");

            return result;
        }
    }
}
