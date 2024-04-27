﻿using Query.Base;
using Domain.PostDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Post
{
    public record GetPostListQuery : IQuery<List<PostDTO>>;
}
