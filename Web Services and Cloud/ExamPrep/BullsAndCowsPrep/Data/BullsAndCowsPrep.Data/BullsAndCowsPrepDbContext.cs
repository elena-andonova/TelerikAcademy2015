namespace BullsAndCowsPrep.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BullsAndCowsPrepDbContext : IdentityDbContext<User>, IBullsAndCowsPrepDbContext
    {
        public BullsAndCowsPrepDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BullsAndCowsPrepDbContext Create()
        {
            return new BullsAndCowsPrepDbContext();
        }
    }
}
