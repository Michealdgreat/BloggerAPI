using MediatR;


namespace Application.Post.CreatePost
{
    public class CreatePostCommand : IRequest
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string PostUrl { get; set; }
        public required string Content { get; set; }
        public required string FeaturedImageUrl { get; set; }
        public required string Author { get; set; }
        public required string CategoryNames { get; set;}
    }
}
