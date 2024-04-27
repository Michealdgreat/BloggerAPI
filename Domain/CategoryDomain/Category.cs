﻿using Domain.PostDomain;

namespace Domain.CategoryDomain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post>? Posts { get; set; }
    }
}
