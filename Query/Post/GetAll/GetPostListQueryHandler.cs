using Domain.PostDomain;
using Infrastructure.DataAccess;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post.GetAll
{
    public class GetPostListQueryHandler(IRepositoryBase repositoryBase) : IQueryHandler<GetPostListQuery, List<PostDTO>>
    {
        private readonly IRepositoryBase _repoBase = repositoryBase;

        public async Task<List<PostDTO>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {

            var result = await _repoBase.FromDataBase<PostDTO, dynamic>("GetAllPosts", new { }, "BloggerConnStrings");

            return result;
            //return Task.FromResult(new List<PostDTO>());
        }
    }
}
