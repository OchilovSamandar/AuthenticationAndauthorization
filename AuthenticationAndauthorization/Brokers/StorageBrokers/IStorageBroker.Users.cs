using AuthenticationAndauthorization.Models;

namespace AuthenticationAndauthorization.Brokers.StorageBrokers
{
    public partial interface IStorageBroker
    {
        IQueryable<User> SelectAllUsers();
        ValueTask<User> SelectUserByIdAsync(Guid UserId);
        ValueTask<User> UpdateUserByIdAsync(User user);
        ValueTask<User> DeleteUserByIdAsync(User user);
    }
}
