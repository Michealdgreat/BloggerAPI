using Domain.PostDomain;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post.GetByCategory
{
    public record GetPostByCategoryQuery(string value) : IQuery<List<PostDTO>>;
}
