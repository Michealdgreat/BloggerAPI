using Domain.PostDomain;
using Infrastructure.DataAccess;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post.GetByCategory;

public class GetPostByCategoryQueryHandler(IRepositoryBase repositoryBase) : IQueryHandler<GetPostByCategoryQuery, List<PostDTO>>
{

    private readonly IRepositoryBase _repoBase = repositoryBase;

    public async Task<List<PostDTO>> Handle(GetPostByCategoryQuery request, CancellationToken cancellationToken)
    {
        await _repoBase.FromDataBase<PostDTO, dynamic>("dbo.GetPostsByCategory", new { request.value }, "BloggerConnStrings");

        return await Task.FromResult(new List<PostDTO>());
    }
}

