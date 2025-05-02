using GoodHambuerger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHambuerger.Application.Models;

public class OrderViewModel
{
    public OrderViewModel(int id, decimal total, IEnumerable<Item>? items)
    {
        Id = id;
        Total = total;
        Items = items;
    }

    public int Id { get; set; }
    public decimal Total { get; set; }
    public IEnumerable<Item>? Items { get; set; }

    public static OrderViewModel FromEntity(Order order)
        => new OrderViewModel(order.Id, order.Total, order.Items);
}
