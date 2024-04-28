using Infrastructure.DataAccess;
using MediatR;

namespace Application.Post.CreatePost;

public class CreatePostCommandHandler(IRepositoryBase repositoryBase) : IRequestHandler<CreatePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    //public Task Handle(CreatePostCommand request)
    //{
    //    _repoBase.ToDataBase<dynamic>("dbo.AddPostWithCategories", new { request }, "BloggerConnStrings");

    //    return Task.CompletedTask;
    //}

    public Task Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        _repoBase.ToDataBase<dynamic>("dbo.AddPostWithCategories", new { request }, "BloggerConnStrings");

        return Task.CompletedTask;
    }
}
