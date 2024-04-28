using Domain.PostDomain;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post.GetByTitle
{
    public record GetPostByTitleQuery(string value) : IQuery<List<PostDTO>>;
}
