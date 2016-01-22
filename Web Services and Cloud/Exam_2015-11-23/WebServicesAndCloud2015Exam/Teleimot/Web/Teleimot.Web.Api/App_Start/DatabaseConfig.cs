namespace Teleimot.Web.Api
{
    using System.Data.Entity;
    using Teleimot.Data;
    using Teleimot.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TeleimotDbContext, Configuration>());
        }
    }
}