using Application.Post.CreatePost;
using Application.Post.DeletePost;
using Application.Post.UpdatePost;
using Microsoft.AspNetCore.Mvc;
using PresentationFacade.Post;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BloggerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController(IPostFacade postFacade) : ControllerBase
{
    private readonly IPostFacade _postFacade = postFacade;

    [HttpPost("CreatePost")]
    public async Task<ActionResult> CreatePost([FromBody] CreatePostCommand command)
    {
        await _postFacade.CreatePost(command);

        return Ok("Post Created");
    }
    [HttpPut("UpdatePost")]
    public async Task<ActionResult> UpdatePost([FromBody] UpdatePostCommand command)
    {
        await _postFacade.UpdatePost(command);

        return Ok("Post updated");
    }
    [HttpDelete("DeletePost")]
    public async Task<ActionResult> DeletePost([FromBody] DeletePostCommand command)
    {
        await _postFacade.DeletePost(command);

        return Ok("Post deleted!.");
    }

}
