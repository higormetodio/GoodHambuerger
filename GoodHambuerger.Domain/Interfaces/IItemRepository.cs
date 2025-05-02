using GoodHambuerger.Domain.Entities;

namespace GoodHambuerger.Domain.Interfaces;

public interface IItemRepository
{
    IEnumerable<Item> GetItems();
    Item GetItemById(int id);
    IEnumerable<Item> GetItemsSandwichesOnly();
    IEnumerable<Item> GetItemsExtraOnly();
}
