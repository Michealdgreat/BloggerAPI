

namespace Query.Post.DTO
{
    public class Category
    {
        public required int CategoryId { get; set; }
        public required string Name { get; set; }
        public string? Slug { get; set; }
        public List<PostDTO>? Posts { get; set; }
    }
}
