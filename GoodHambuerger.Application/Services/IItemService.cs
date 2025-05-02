using GoodHambuerger.Application.Models;

namespace GoodHambuerger.Application.Services;

public interface IItemService
{
    ResultViewModel<IEnumerable<ItemViewModel>> ListItems();
    ResultViewModel<IEnumerable<ItemViewModel>> ListSandwichesOnly();
    ResultViewModel<IEnumerable<ItemViewModel>> ListExtrasOnly();
}
