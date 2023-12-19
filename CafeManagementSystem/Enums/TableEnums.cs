using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.Enums
{
  
    public enum TableStatus
    {
        Reserved, // bàn đã được đặt
        Free, // bàn trống
        Occupied // bàn đang có khách
    }
}
