using Microsoft.EntityFrameworkCore;
using RickAndMorty.Models;

namespace RickAndMorty.Data
{
    public class RickAndMortyDbContext:DbContext
    {
        public RickAndMortyDbContext(DbContextOptions<RickAndMortyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Episode>()
                .HasMany(e => e.characters)
                .WithMany(c => c.episode);

            modelBuilder.Entity<Character>()
                .HasOne(c=>c.origin)
                .WithMany()
                .HasForeignKey(c=>c.originId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne(c=>c.location)
                .WithMany()
                .HasForeignKey(c=>c.locationId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Episode> episodes { get; set; }
        public DbSet<Character> characters { get; set; }
        public DbSet<Location> locations { get; set; }
    }
}
