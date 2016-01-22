namespace BullsAndCowsPrep.Web.Api
{
    using System.Data.Entity;
    using BullsAndCowsPrep.Data;
    using BullsAndCowsPrep.Data.Migrations;    

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BullsAndCowsPrepDbContext, Configuration>());
        }
    }
}