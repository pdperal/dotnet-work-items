using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 1,
        PROCESSING = 2,
        SHIPPED = 3,
        DELIVERED = 4
    }
}
