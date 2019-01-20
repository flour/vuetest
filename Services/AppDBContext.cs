using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using testvue.Models;

namespace testvue.Services
{
    public class AppDBContext : DbContext
    {
        public DbSet<Purchase> Purchases { get; set; }

        public AppDBContext() : base()
        {

        }

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            await this.Database.MigrateAsync();
        }
    }
}