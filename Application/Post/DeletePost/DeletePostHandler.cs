using Infrastructure.DataAccess;
using MediatR;


namespace Application.Post.DeletePost;

public class DeletePostHandler(IRepositoryBase repositoryBase) : IRequest<DeletePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public Task Handle(DeletePostCommand request)
    {
        _repoBase.ToDataBase<dynamic>("dbo.DeletePost", new { }, "BloggerConnStrings");

        return Task.CompletedTask;
    }

}
