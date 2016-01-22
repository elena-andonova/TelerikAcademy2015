namespace StudentsSystem.ConsoleClient
{
    using Data;
    using Models;
    using Data.Migrations;
    using System;
    using System.Data.Entity;

    public class Startup
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsDbContext, Configuration>());

            var db = new StudentsDbContext();

            db.Students.Add(new Student { Name = "Bubu" });            

            db.SaveChanges();
        }
    }
}
