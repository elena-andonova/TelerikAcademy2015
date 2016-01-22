namespace SocialNetwork.Data
{
    using SocialNetwork.Models;
    using System.Data.Entity;

    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext()
            : base("SocialNetworkDb")
        {
        }

        public IDbSet<UserProfile> UserProfiles { get; set; }

        public IDbSet<Image> Images { get; set; }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Friendship> Friendships { get; set; }

        public IDbSet<ChatMessage> ChatMessages { get; set; }
    }
}
