using System;
using Microsoft.EntityFrameworkCore;
using Layers.API.Models;

namespace Layers.API.Context
{
    public class LayersDbContext : DbContext
    {
        public LayersDbContext(
            DbContextOptions<LayersDbContext> layersOptions)
            : base(layersOptions)
        {
            //
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasKey(b => b.Ident);
        }
    }
}