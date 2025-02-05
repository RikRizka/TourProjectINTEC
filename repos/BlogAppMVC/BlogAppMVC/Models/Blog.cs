﻿using Microsoft.EntityFrameworkCore;

namespace BlogApp.Models
{

    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
