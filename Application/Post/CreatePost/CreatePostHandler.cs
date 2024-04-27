using Infrastructure.DataAccess;
using MediatR;


namespace Application.Post.CreatePost;

public class CreatePostHandler(IRepositoryBase repositoryBase) : IRequest<CreatePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public Task Handle(CreatePostCommand request)
    {
        _repoBase.ToDataBase<dynamic>("dbo.AddPostWithCategories", new { request }, "BloggerConnStrings");

        return Task.CompletedTask;
    }
}
