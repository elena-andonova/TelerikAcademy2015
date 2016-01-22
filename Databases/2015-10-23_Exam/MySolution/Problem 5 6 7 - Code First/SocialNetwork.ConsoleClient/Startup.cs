﻿namespace SocialNetwork.ConsoleClient
{
    using System.Data.Entity;
    using SocialNetwork.Data;
    using SocialNetwork.Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SocialNetworkDbContext, Configuration>());

            var db = new SocialNetworkDbContext();
            db.Database.CreateIfNotExists();
        }
    }
}
