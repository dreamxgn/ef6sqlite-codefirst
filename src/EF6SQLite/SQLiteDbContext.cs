using System.Data.Entity;

namespace EF6SQLite
{
    public class SQLiteDbContext : DbContext
    {
        public SQLiteDbContext() : base("Default")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}