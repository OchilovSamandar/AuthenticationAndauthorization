using AuthenticationAndauthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndauthorization.Brokers.StorageBrokers
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }
        public async ValueTask<User> SelectUserByIdAsync(Guid UserId) =>
            await SelectAsync<User>(UserId);

        public async ValueTask<User> UpdateUserByIdAsync(User user) =>
            await UpdateAsync<User>(user);
        public IQueryable<User> SelectAllUsers() =>
            SelectAll<User>();
        public async ValueTask<User> DeleteUserByIdAsync(User user) =>
            await DeleteAsync<User>(user);
    }
}