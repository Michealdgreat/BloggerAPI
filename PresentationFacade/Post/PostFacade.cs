﻿using Application.Post.CreatePost;
using Application.Post.DeletePost;
using Application.Post.UpdatePost;
using Query.Post.DTO;
using MediatR;
using Query.Post.GetAll;
using Query.Post.GetByCategory;
using Query.Post.GetById;
using Query.Post.GetByTitle;

namespace PresentationFacade.Post;

public class PostFacade(IMediator mediator) : IPostFacade
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

    public async Task<PostDTO?> GetPostById(int query)
    {
        return await _mediator.Send(new GetPostByIdQuery(query));
    }

    public async Task<List<PostDTO>> GetAllPosts()
    {
        return await _mediator.Send(new GetPostListQuery());
    }

    public async Task<List<PostDTO>> GetPostByTitle(string query)
    {
        return await _mediator.Send(new GetPostByTitleQuery(query));
    }

    public async Task<List<PostDTO>> GetPostByCategory(string query)
    {
        return await _mediator.Send(new GetPostByCategoryQuery(query));
    }

}
