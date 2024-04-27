using Domain.PostDomain;

namespace Domain.CategoryDomain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<PostDTO>? Posts { get; set; }
    }
}
