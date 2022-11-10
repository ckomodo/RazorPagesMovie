using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Cast> Cast { get; set; } = default!;
        public DbSet<Actor> Actor { get; set; } = default!;
        public DbSet<Review> Review { get; set; }
        public DbSet<Production> Production { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Cast>().ToTable("Cast");
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Production>().ToTable("Production");

        }
    }
}
