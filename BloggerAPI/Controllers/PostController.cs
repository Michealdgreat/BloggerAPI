using Application.Post.CreatePost;
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

        return Ok("Task Completed");


    }

}
