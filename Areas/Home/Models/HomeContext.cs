using Microsoft.EntityFrameworkCore;

namespace aspcore.Areas.Home.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions<HomeContext> options): base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=reviews.db");
        }
        public DbSet<aspcore.Areas.Home.Models.User> User { get; set; }
    }
}