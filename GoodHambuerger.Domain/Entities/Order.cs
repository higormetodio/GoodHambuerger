using GoodHambuerger.Domain.Entities.Enums;
using System.Text.Json.Serialization;

namespace GoodHambuerger.Domain.Entities;

public class Order : BaseEntity
{
    public Order(int id) : base(id)
    {
        Items = [];
    }

    public decimal Total { get; private set; } = default;

    [JsonIgnore]
    public List<Item> Items { get; private set; }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void Discount()
    {
        Total = Items.Sum(item => item.Price);

        var haveSandwich = Items.Any(item => item.Type.Equals(ItemType.Sandwich));
        var haveFries = Items.Any(item => item.Name.Equals("Fries"));
        var haveDrink = Items.Any(item => item.Name.Equals("Soft drink"));
        
        if (haveSandwich && haveFries && haveDrink)
        {
            Total = Total - (Total * 0.2m);
            return;
        }

        if (haveSandwich && haveDrink)
        {
            Total = Total - (Total * 0.15m);
            return;
        }

        if (haveSandwich && haveFries)
        {
            Total = Total - (Total * 0.1m);
            return;
        }
    }

    public (int, int, int) CountItemsOrder()
    {
        var sandwiches = Items.Count(item => item.Type.Equals(ItemType.Sandwich));
        var fries = Items.Count(item => item.Name.Equals("Fries"));
        var drinks = Items.Count(item => item.Name.Equals("Soft drink"));
        return (sandwiches, fries, drinks);
    }

    public void RemoveItems()
    {
        Items.Clear();
    }
}
