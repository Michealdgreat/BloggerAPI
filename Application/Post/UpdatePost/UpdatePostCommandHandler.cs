using Infrastructure.DataAccess;
using MediatR;

namespace Application.Post.UpdatePost;

public class UpdatePostCommandHandler(IRepositoryBase repositoryBase) : IRequestHandler<UpdatePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;


    public async Task Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        var postid = await _repoBase.GetOneFromDataBase<PostIdDTO, dynamic>("dbo.GetPostsByPostUrl", new { request.PostUrl }, "BloggerConnStrings");
        await _repoBase.ToDataBase<dynamic>("dbo.UpdatePost", new { postid.postID, request.PostUrl, request.Author, request.Description, request.Title, request.FeaturedImageUrl, request.Content, request.IsVisible }, "BloggerConnStrings");


    }
}
