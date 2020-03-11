using Microsoft.EntityFrameworkCore;

namespace PostgresApi.Models
{
    public class WebApiContext:DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().OwnsOne(x => x.Balance);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Account> Accounts{ get; set; }

    }
}