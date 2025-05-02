using GoodHambuerger.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GoodHambuerger.Domain.Entities;

public class Item : BaseEntity
{
    public Item(int id, string name, ItemType type, decimal price) : base(id)
    {
        Name = name;
        Type = type;
        Price = price;
    }

    public string Name { get; private set; }
    public ItemType Type { get; private set; }
    public decimal Price { get; private set; }

    [JsonIgnore]
    public IEnumerable<Order> Orders { get; private set; }
}
