using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using testvue.Models;

namespace testvue.Services
{
    public class AppDBContext : DbContext
    {
        public DbSet<Purchase> Purchases { get; set; }

        public AppDBContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}