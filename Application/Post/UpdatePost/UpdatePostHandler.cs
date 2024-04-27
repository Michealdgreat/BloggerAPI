using Infrastructure.DataAccess;
using MediatR;

namespace Application.Post.UpdatePost;

public class UpdatePostHandler(IRepositoryBase repositoryBase) : IRequest<UpdatePostCommand>
{
    private readonly IRepositoryBase _repoBase = repositoryBase;

    public Task Handle(UpdatePostCommand request)
    {
        _repoBase.ToDataBase<dynamic>("", new { request }, "");

        return Task.CompletedTask;
    }
}
