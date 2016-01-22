namespace Teleimot.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;
    using Teleimot.Services.Data.Contracts;

    public class UsersService : IUsersService
    {
        private IRepository<User> users;

        public UsersService(IRepository<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> GetUserDetails(string userName)
        {
            return this.users
                .All()
                .Where(u => u.UserName == userName);
        }

        public void RateUser(string userId, int value)
        {
            var user = this.users.GetById(userId);

            user.Rating += value;

            this.users.SaveChanges();
        }
    }
}
