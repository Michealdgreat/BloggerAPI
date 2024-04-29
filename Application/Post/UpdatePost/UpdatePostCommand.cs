using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Post.UpdatePost
{
    public class UpdatePostCommand : IRequest
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? PostUrl { get; set; }
        public required string Content { get; set; }
        public string? FeaturedImageUrl { get; set; }
        public required string Author { get; set; }
        public List<int>? CategoryIds { get; set; }
    }
}
