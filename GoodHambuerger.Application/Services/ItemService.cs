using GoodHambuerger.Application.Models;
using GoodHambuerger.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHambuerger.Application.Services;

public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public ResultViewModel<IEnumerable<ItemViewModel>> ListItems()
    {
        var items = _itemRepository.GetItems();

        var model = items.Select(ItemViewModel.FromEntity).ToList();

        return ResultViewModel<IEnumerable<ItemViewModel>>.Success(model);
    }

    public ResultViewModel<IEnumerable<ItemViewModel>> ListSandwichesOnly()
    {
        var items = _itemRepository.GetItemsSandwichesOnly();

        var model = items.Select(ItemViewModel.FromEntity).ToList();

        return ResultViewModel<IEnumerable<ItemViewModel>>.Success(model);
    }
    public ResultViewModel<IEnumerable<ItemViewModel>> ListExtrasOnly()
    {
        var items = _itemRepository.GetItemsExtraOnly();

        var model = items.Select(ItemViewModel.FromEntity).ToList();

        return ResultViewModel<IEnumerable<ItemViewModel>>.Success(model);
    }    
}
