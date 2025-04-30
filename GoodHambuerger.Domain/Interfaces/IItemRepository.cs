using GoodHambuerger.Domain.Entities;

namespace GoodHambuerger.Domain.Interfaces;

public interface IItemRepository
{
    IEnumerable<Item> GetItems();
    IEnumerable<Item> GetItemsSandwichesOnly();
    IEnumerable<Item> GetItemsExtraOnly();
}
