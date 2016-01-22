namespace Teleimot.Data
{
    using Teleimot.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class TeleimotDbContext : IdentityDbContext<User>, ITeleimotDbContext
    {
        public TeleimotDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TeleimotDbContext Create()
        {
            return new TeleimotDbContext();
        }
    }
}
