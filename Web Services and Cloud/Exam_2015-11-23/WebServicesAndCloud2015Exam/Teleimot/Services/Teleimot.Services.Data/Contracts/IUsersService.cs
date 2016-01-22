namespace Teleimot.Services.Data.Contracts
{
    using System.Linq;
    using Teleimot.Data.Models;

    public interface IUsersService
    {
        IQueryable<User> GetUserDetails(string userName);

        void RateUser(string userId, int value);
    }
}
