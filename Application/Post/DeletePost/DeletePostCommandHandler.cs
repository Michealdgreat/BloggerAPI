using Infrastructure.DataAccess;
using MediatR;

namespace Application.Post.DeletePost;

public class DeletePostCommandHandler(IRepositoryBase repositoryBase) : IRequestHandler<DeletePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public async Task Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        await _repoBase.ToDataBase<dynamic>("dbo.DeletePost", new { @postId = request.id }, "BloggerConnStrings");
    }
}
