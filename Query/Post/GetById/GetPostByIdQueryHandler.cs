using Domain.PostDomain;
using Infrastructure.DataAccess;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post.GetById
{
    public class GetPostByIdQueryHandler(IRepositoryBase repositoryBase) : IQueryHandler<GetPostByIdQuery, PostDTO>
    {
        private readonly IRepositoryBase _repoBase = repositoryBase;

        public async Task<PostDTO> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repoBase.GetOneFromDataBase<PostDTO, dynamic>("dbo.GetPost", new { @PostId = request.id }, "BloggerConnStrings");

            return result;
        }
    }
}
