﻿using Microsoft.AspNetCore.Identity;

namespace AuthenticationAndauthorization.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Role Role { get; set; }
        public List<Product> Products { get; set; } = null!;
    }
}
