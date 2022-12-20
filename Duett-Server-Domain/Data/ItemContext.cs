using System;
using Duett_Server_Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Duett_Server_Domain.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options) { }
        public DbSet<ListItem> ListItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
        .UseSqlite("Data Source=Application.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListItem>()
                .Property(x => x.Id)
                .HasColumnName("id");
        }
    }
}