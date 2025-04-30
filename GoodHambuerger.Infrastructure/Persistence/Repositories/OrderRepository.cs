using GoodHambuerger.Domain.Entities;
using GoodHambuerger.Domain.Interfaces;

namespace GoodHambuerger.Infrastructure.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly GoodHamburgerDbContext _context;

    public OrderRepository(GoodHamburgerDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Order> GetOrders()
        => _context.Orders.ToList();

    public Order GetOrderById(int id)
        => _context.Orders.FirstOrDefault(o => o.Id == id)!;
        
    public void SendOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public void UpdateOrder(Order order)
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
    }

    public void RemoveOrder(Order order)
    {
        _context.Orders.Remove(order);
        _context.SaveChanges();
    }
}
