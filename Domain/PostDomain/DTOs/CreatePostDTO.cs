using Domain.CategoryDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PostDomain.DTOs
{
    public class CreatePostDTO
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string PostUrl { get; set; }
        public required string Content { get; set; }
        public required string FeaturedImageUrl { get; set; }
        public DateTime PublishedDate { get; set; }
        public required string Author { get; set; }
        public bool IsVisible { get; set; }
        public required List<Category> Categories { get; set; }
    }
}
