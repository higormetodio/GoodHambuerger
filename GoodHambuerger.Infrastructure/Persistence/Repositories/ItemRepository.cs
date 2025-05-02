using GoodHambuerger.Domain.Entities;
using GoodHambuerger.Domain.Entities.Enums;
using GoodHambuerger.Domain.Interfaces;

namespace GoodHambuerger.Infrastructure.Persistence.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly GoodHamburgerDbContext _context;

    public ItemRepository(GoodHamburgerDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Item> GetItems()
        => _context.Items.ToList();

    public Item GetItemById(int id)
        => _context.Items
            .FirstOrDefault(item => item.Id == id)!;

    public IEnumerable<Item> GetItemsExtraOnly()
        => _context.Items
            .Where(item => item.Type.Equals(ItemType.Extra))
            .ToList();

    public IEnumerable<Item> GetItemsSandwichesOnly()
        => _context.Items
            .Where(item => item.Type.Equals(ItemType.Sandwich))
            .ToList();
}
