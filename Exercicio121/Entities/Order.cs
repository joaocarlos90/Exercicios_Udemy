using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio121.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
