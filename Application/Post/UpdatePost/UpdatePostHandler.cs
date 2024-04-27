using Application.Post.EditPost;
using Infrastructure.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Post.UpdatePost;

public class UpdatePostHandler(IRepositoryBase repositoryBase) : IRequest<EditPostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public Task Handle(EditPostCommand request)
    {
        _repoBase.ToDataBase<dynamic>("", new { request }, "");

        return Task.CompletedTask;
    }
}
