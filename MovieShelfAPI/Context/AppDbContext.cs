using Microsoft.EntityFrameworkCore;
using MovieShelfAPI.Models;

namespace MovieShelfAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Movies)
                .UsingEntity<MovieCategory>();
        }
    }
}
