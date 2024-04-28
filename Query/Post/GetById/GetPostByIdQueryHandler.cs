using Infrastructure.DataAccess;
using Query.Base;
using Query.Post.DTO;


namespace Query.Post.GetById
{
    public class GetPostByIdQueryHandler(IRepositoryBase repositoryBase) : IQueryHandler<GetPostByIdQuery, PostDTO?>
    {
        private readonly IRepositoryBase _repoBase = repositoryBase;

        public async Task<PostDTO?> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repoBase.GetOneFromDataBase<PostDTO, dynamic>("dbo.GetPost", new { @PostId = request.id }, "BloggerConnStrings");

            return result;
        }
    }
}
