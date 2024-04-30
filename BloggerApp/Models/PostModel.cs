namespace BloggerApp.Models
{
    public class PostModel
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string PostUrl { get; set; }
        public required string Content { get; set; }
        public required string FeaturedImageUrl { get; set; }
        public required string Author { get; set; }
        public required string CategoryNames { get; set; }
    }
}
