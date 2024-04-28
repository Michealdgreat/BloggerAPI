using MediatR;


namespace Application.Post.CreatePost
{
    public class CreatePostCommand : IRequest
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? PostUrl { get; set; }
        public required string Content { get; set; }
        public string? FeaturedImageUrl { get; set; }
        public required string Author { get; set; }
        public List<Guid>? CategoryIds { get; set; }
    }
}
