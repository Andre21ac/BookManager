using BookManagerConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManagerConsoleApp.Infraestructure
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "DataBase.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
