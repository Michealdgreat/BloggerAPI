using Query.Post.DTO;
using System;

namespace Query.Post.DTO
{
    public class PostDTO
    {
        public int PostId { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public required string PostUrl { get; set; }
        public required string Content { get; set; }
        public required string FeaturedImageUrl { get; set; }
        public DateTime PublishedDate { get; set; }
        public required string Author { get; set; }
        public bool IsVisible { get; set; }
        public required List<Category> Categories { get; set; }
    }
}
