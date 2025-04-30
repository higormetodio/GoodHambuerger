using GoodHambuerger.Domain.Entities.Enums;

namespace GoodHambuerger.Domain.Entities;

public class Order : BaseEntity
{
    public Order(List<Item> items)
    {
        Items = items;
        Discount();
    }

    public decimal Total { get; private set; }
    public List<Item> Items { get; private set; }

    private void Discount()
    {
        Total = Items.Sum(item => item.Price);

        var haveSandwich = Items.Any(item => item.Type.Equals(ItemType.Sandwich));
        var haveFries = Items.Any(item => item.Name.Equals("Fries"));
        var haveDrink = Items.Any(item => item.Name.Equals("Soft Drink"));
        
        if (haveSandwich && haveFries && haveDrink)
        {
            Total = Total - (Total * 0.2m);
        }

        if (haveSandwich && haveDrink)
        {
            Total = Total - (Total * 0.15m);
        }

        if (haveSandwich && haveFries)
        {
            Total = Total - (Total * 0.1m);
        }
    }

    public void UpdateOrder(List<Item> items)
    {
        Items = items;
        Discount();
    }



}
