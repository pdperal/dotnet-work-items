using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4
    }
}
