﻿using Infrastructure.DataAccess;
using MediatR;

namespace Application.Post.UpdatePost;

public class UpdatePostCommandHandler(IRepositoryBase repositoryBase) : IRequest<UpdatePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public Task Handle(UpdatePostCommand request)
    {
        _repoBase.ToDataBase<dynamic>("dbo.UpdatePost", new { request }, "BloggerConnStrings");

        return Task.CompletedTask;
    }
}