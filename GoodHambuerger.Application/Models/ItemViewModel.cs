using GoodHambuerger.Domain.Entities;
using GoodHambuerger.Domain.Entities.Enums;

namespace GoodHambuerger.Application.Models;

public class ItemViewModel
{
    public ItemViewModel(int id, string name, ItemType type, decimal price)
    {
        Id = id;
        Name = name;
        Type = type;
        Price = price;
    }

    public int Id { get; set; }
    public string Name { get; private set; }
    public ItemType Type { get; private set; }
    public decimal Price { get; private set; }

    public static ItemViewModel FromEntity(Item item)
        => new(item.Id, item.Name, item.Type, item.Price);
}
