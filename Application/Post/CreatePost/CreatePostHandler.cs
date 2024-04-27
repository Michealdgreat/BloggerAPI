using Infrastructure.DataAccess;
using MediatR;
using Domain.PostDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Post.CreatePost;

public class CreatePostHandler(IRepositoryBase repositoryBase) : IRequest<CreatePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public Task Handle(CreatePostCommand request)
    {
        _repoBase.ToDataBase<dynamic>("", new { request }, "");

        return Task.CompletedTask;
    }
}
