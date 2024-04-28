using Application.Post.CreatePost;
using Application.Post.DeletePost;
using Application.Post.UpdatePost;
using Domain.PostDomain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Post.GetAll;
using Query.Post.GetById;
using Query.Post.GetByTitle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationFacade.Post;

public class PostFacade(IMediator mediator)
{
    private readonly IMediator _mediator = mediator;

    public async Task CreatePost(CreatePostCommand command)
    {
        await _mediator.Send(command);
    }

    public async Task UpdatePost(UpdatePostCommand command)
    {
        await _mediator.Send(command);
    }

    public async Task DeletePost(DeletePostCommand command)
    {
        await _mediator.Send(command);
    }

    public async Task<PostDTO> GetPostById(GetPostByIdQuery query)
    {
        return await _mediator.Send(query);
    }

    public async Task<List<PostDTO>> GetAllPosts()
    {
        return await _mediator.Send(new GetPostListQuery());
    }

    public async Task<List<PostDTO>> GetPostByTitle(GetPostByTitleQuery query)
    {
        return await _mediator.Send(query);
    }

}
