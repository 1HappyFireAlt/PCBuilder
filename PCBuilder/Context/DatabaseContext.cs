using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Model;

namespace PCBuilder.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Builds> Builds { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Community> Communities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "database.db");
            optionbuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
