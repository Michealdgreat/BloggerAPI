﻿using Domain.CategoryDomain;
using System;

namespace Domain.PostDomain
{
    public class Post
    {
        public Guid PostId { get; set; }
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