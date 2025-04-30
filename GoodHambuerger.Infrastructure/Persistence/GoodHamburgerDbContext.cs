using GoodHambuerger.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoodHambuerger.Infrastructure.Persistence;

public class GoodHamburgerDbContext : DbContext
{
    public GoodHamburgerDbContext(DbContextOptions<GoodHamburgerDbContext> options) : base(options)
    {     
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
}
