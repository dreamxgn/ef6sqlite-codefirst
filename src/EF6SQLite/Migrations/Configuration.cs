using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace EF6SQLite.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SQLiteDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(SQLiteDbContext context)
        {
            context.Users.AddOrUpdate(p => p.Username, new User
            {
                Username = "Admin",
                Password = "Admin888",
                Enabled = true,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Name = "Photo 1",
                        Url = "https://www.coderbusy.com/"
                    },
                    new Photo
                    {
                        Name = "Photo 2",
                        Url = "https://www.coderbusy.com/"
                    },
                    new Photo
                    {
                        Name = "Photo 3",
                        Url = "https://www.coderbusy.com/"
                    }
                }
            });
        }
    }
}