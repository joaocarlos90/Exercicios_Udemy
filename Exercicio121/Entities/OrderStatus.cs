using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio121.Entities
{
    public enum OrderStatus : int
    {
        Pending_Payment =0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
