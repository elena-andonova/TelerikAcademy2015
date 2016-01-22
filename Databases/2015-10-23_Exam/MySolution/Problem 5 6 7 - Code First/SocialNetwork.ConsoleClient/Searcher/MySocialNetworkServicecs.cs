namespace SocialNetwork.ConsoleClient.Searcher
{
    using System;
    using System.Linq;
    using SocialNetwork.Data;

    public class MySocialNetworkService: ISocialNetworkService
    {

        public System.Collections.IEnumerable GetUsersAfterCertainDate(int year)
        {
            var db = new SocialNetworkDbContext();
            var users = db.UserProfiles
                .Where(u => u.RegistrationDate.Year >= year)
                .Select(u => new
                {
                    u.Username,
                    u.FirstName,
                    u.LastName,
                    NumberOfImages = u.Images.Count()
                })
                .ToList();

                return users;
        }

        public System.Collections.IEnumerable GetPostsByUser(string username)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerable GetFriendships(int page = 1, int pageSize = 25)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerable GetChatUsers(string username)
        {
            throw new NotImplementedException();
        }
    }
}
