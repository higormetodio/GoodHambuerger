using GoodHambuerger.Domain.Entities;
using GoodHambuerger.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace GoodHambuerger.Infrastructure.Persistence;

public class GoodHamburgerDbContext : DbContext
{
    public GoodHamburgerDbContext(DbContextOptions<GoodHamburgerDbContext> options) : base(options)
    {     
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {       
        builder.Entity<Item>().HasData(
            new Item(1, "X Burger", ItemType.Sandwich, 5.00m),
            new Item(2, "X Egg", ItemType.Sandwich, 4.50m),
            new Item(3, "X Bacon", ItemType.Sandwich, 7.00m),
            new Item(4, "Fries", ItemType.Extra, 2.00m),
            new Item(5, "Soft drink", ItemType.Extra, 2.50m)
            );
    }
}
