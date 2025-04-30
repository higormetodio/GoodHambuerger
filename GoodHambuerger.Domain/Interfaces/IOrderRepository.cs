using GoodHambuerger.Domain.Entities;

namespace GoodHambuerger.Domain.Interfaces;

public interface IOrderRepository
{
    void SendOrder(Order order);
    IEnumerable<Order> GetOrders();
    Order GetOrderById(int id);
    void UpdateOrder(Order order);
    void RemoveOrder(Order order);
}
