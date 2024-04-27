using Domain.PostDomain;
using Infrastructure.DataAccess;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post
{
    public class GetPostListQueryHandler(IRepositoryBase repositoryBase) : IQueryHandler<GetPostListQuery, List<PostDTO>>
    {
        private readonly IRepositoryBase _repoBase = repositoryBase;

        public async Task<List<PostDTO>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {

            await _repoBase.FromDataBase<PostDTO, dynamic>("", new { }, "BloggerConnStrings");

            return await Task.FromResult(new List<PostDTO>());
        }
    }
}
