﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Post.DeletePost;

public class DeletePostCommand : IRequest
{
    public int id { get; set; }
}
