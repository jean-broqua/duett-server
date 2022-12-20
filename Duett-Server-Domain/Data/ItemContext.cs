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

            modelBuilder.Entity<ListItem>().HasData(
                    new ListItem("Banana", 15, 25),
                    new ListItem("Pêra", 8, 12),
                    new ListItem("Abacaxi", 35, 10),
                    new ListItem("Maçã", 30, 14),
                    new ListItem("Uva", 17, 73),
                    new ListItem("Melancia", 8, 1));
        }
    }
}