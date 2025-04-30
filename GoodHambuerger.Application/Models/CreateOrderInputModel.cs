using GoodHambuerger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodHambuerger.Application.Models
{
    public class CreateOrderInputModel
    {
        public IEnumerable<Item> Items { get; private set; }
    }
}
