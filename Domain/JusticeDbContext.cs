using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class JusticeDbContext : DbContext
    {
        public JusticeDbContext()
        {

        }
        public JusticeDbContext(DbContextOptions<JusticeDbContext> options)
            : base(options) { }
        
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Article>? Articles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost; database=justicedb; user=root; password=", new MySqlServerVersion(new Version(8, 0 , 11)));
        }
    }
}