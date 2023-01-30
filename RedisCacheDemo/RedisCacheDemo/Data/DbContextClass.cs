using Microsoft.EntityFrameworkCore;
using RedisCacheDemo.Model;

namespace RedisCacheDemo.Data
{
    public class DbContextClass: DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(u => new
            {
                u.ProductId
            });
            modelBuilder.Entity<Product>().Property(t => t.ProductId).ValueGeneratedOnAdd();
        }
    }
}
