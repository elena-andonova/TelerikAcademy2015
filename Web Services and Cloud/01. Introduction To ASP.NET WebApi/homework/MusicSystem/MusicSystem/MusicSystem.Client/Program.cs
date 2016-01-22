using MusicSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSystem.Client
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicDbContext, Configuration>());
            var db = new MusicDbContext();

            db.Database.CreateIfNotExists();
        }
    }
}
