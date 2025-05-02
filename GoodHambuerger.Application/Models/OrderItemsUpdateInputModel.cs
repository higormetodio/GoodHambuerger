using GoodHambuerger.Domain.Entities;

namespace GoodHambuerger.Application.Models
{
    public class OrderItemsUpdateInputModel
    {
        public int Id { get; set; }
        public List<int>? ItemsOrder { get; set; }
    }
}
