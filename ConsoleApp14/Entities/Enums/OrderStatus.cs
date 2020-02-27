using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4
    }
}
