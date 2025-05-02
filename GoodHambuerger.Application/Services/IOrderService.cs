using GoodHambuerger.Application.Models;

namespace GoodHambuerger.Application.Services;

public interface IOrderService
{
    ResultViewModel<decimal> CreateOrder(OrderItemsInputModel model);
    ResultViewModel<IEnumerable<OrderViewModel>> ListOrders();
    ResultViewModel UpdateOrder(OrderItemsUpdateInputModel model);
    ResultViewModel DeleteOrder(int id);

}
