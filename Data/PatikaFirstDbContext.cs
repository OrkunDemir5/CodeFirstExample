using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=PatikaCodeFirstDb1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010 },
                new Movie() { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 }
                );
            modelBuilder.Entity<Game>().HasData(
                new Game() { Id = 1, Name = "The Witcher 3", Platform = "PC", Rating = 9.8m },
                new Game() { Id = 2, Name = "The Witcher 3", Platform = "PC", Rating = 9.8m }
                );
        }
    }
}
