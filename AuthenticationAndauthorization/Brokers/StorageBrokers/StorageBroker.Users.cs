using AuthenticationAndauthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndauthorization.Brokers.StorageBrokers
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }
        public ValueTask<User> SelectUserByIdAsync(Guid UserId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> UpdateUserByIdAsync(User user)
        {
            throw new NotImplementedException();
        }
        public IQueryable<User> SelectAllUsers()
        {
            throw new NotImplementedException();
        }
        public ValueTask<User> DeleteUserByIdAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}