using GoodHambuerger.Domain.Entities;

namespace GoodHambuerger.Application.Models
{
    public class OrderItemsInputModel
    {
        public List<int>? ItemsOrder { get; set; }

        public static Order ToEntity(int id)
        => new Order(id);
    }
}
