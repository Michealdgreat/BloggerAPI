using Domain.PostDomain;
using Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post.GetById
{
    public record GetPostByIdQuery(int id) : IQuery<PostDTO>;
}
