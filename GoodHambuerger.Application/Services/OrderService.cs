using GoodHambuerger.Application.Models;
using GoodHambuerger.Domain.Entities;
using GoodHambuerger.Domain.Entities.Enums;
using GoodHambuerger.Domain.Interfaces;

namespace GoodHambuerger.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IItemRepository _itemRepository;

    public OrderService(IOrderRepository orderRepository, IItemRepository itemRepository)
    {
        _orderRepository = orderRepository;
        _itemRepository = itemRepository;
    }

    public ResultViewModel<decimal> CreateOrder(OrderItemsInputModel model)
    {
        var id = _orderRepository.GetOrders().LastOrDefault()?.Id + 1 ?? 1;

        var order = OrderItemsInputModel.ToEntity(id);

        foreach (var itemId in model.ItemsOrder!)
        {            
            var item = _itemRepository.GetItemById(itemId);

            if (item is null)
            {
                return ResultViewModel<decimal>.Error($"Item with Id {itemId} not found.");
            }

            order.AddItem(item);
        }

        order.Discount();

        var (countSandwitch, countFrie, coutDrink) = order.CountItemsOrder();

        if (countSandwitch > 1)
        {
            return ResultViewModel<decimal>.Error($"Order with more than one sandwich.");
        }

        if (countFrie > 1)
        {
            return ResultViewModel<decimal>.Error($"Order with more than one frie.");
        }

        if (coutDrink > 1)
        {
            return ResultViewModel<decimal>.Error($"Order with more than one soda.");
        }

        _orderRepository.AddOrder(order);

        return ResultViewModel<decimal>.Success(order.Total);
    }

    public ResultViewModel<IEnumerable<OrderViewModel>> ListOrders()
    {
        var orders = _orderRepository.GetOrders();

        var model = orders.Select(OrderViewModel.FromEntity).ToList();

        return ResultViewModel<IEnumerable<OrderViewModel>>.Success(model);
    }

    public ResultViewModel UpdateOrder(OrderItemsUpdateInputModel model)
    {
        var order = _orderRepository.GetOrderById(model.Id);

        if (order is null)
        {
            return ResultViewModel.Error($"Order with Id {model.Id} not found.");
        }

        order.RemoveItems();

        foreach (var itemId in model.ItemsOrder!)
        {
            var item = _itemRepository.GetItemById(itemId);

            if (item is null)
            {
                return ResultViewModel<decimal>.Error($"Item with Id {itemId} not found.");
            }

            order.AddItem(item);
        }

        order.Discount();

        var (countSandwitch, countFrie, coutDrink) = order.CountItemsOrder();

        if (countSandwitch > 1)
        {
            return ResultViewModel<decimal>.Error($"Order with more than one sandwich.");
        }

        if (countFrie > 1)
        {
            return ResultViewModel<decimal>.Error($"Order with more than one frie.");
        }

        if (coutDrink > 1)
        {
            return ResultViewModel<decimal>.Error($"Order with more than one soda.");
        }

        _orderRepository.UpdateOrder(order);

        return ResultViewModel.Success();
    }

    public ResultViewModel DeleteOrder(int id)
    {
        var order = _orderRepository.GetOrderById(id);

        if (order is null)
        {
            return ResultViewModel.Error($"Order with Id {id} not found.");
        }

        _orderRepository.RemoveOrder(order);

        return ResultViewModel.Success();
    }
}
