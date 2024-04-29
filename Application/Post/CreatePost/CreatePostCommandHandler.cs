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

    public async Task Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        await _repoBase.ToDataBase<dynamic>("dbo.AddPostWithCategories", new { request.Description, request.Author, request.Title, request.FeaturedImageUrl, request.Content, request.PostUrl, request.CategoryNames }, "BloggerConnStrings");

    }
}
