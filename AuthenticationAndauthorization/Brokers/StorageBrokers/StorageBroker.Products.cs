﻿using AuthenticationAndauthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndauthorization.Brokers.StorageBrokers
{
    public partial class StorageBroker
    {
        public DbSet<Product> Products { get; set; }
        public ValueTask<Product> InsertProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> SelectAllProducts()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> SelectProductByIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }
        public ValueTask<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
        public ValueTask<Product> DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
