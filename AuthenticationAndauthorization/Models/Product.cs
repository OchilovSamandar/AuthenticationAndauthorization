﻿namespace AuthenticationAndauthorization.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public Guid OwnerUserId { get; set; }
        public User User { get; set; } = null!;
    }
}
