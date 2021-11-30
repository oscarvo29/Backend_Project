using ChristiansOeBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ChristiansOeBackend.Repositories
{
    public class ChrisitansOeContex : DbContext
    {
        public ChrisitansOeContex(DbContextOptions<ChrisitansOeContex> options) : base(options)
        {
        }


        public DbSet<Marker> Markers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marker>().ToTable("Course");
        }
    }
}