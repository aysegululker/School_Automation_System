using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity.Enum
{
    public enum Status
    {
        None = 0,
        Active = 1,
        Updated = 2,
        Deleted = 3,
        PreRegistrationed = 4, //Ön kayıt tablosu için
        Disconnected = 5 //İlişkisi kesilenler için
    }
}
