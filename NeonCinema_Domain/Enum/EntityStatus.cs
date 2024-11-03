using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Enum
{
    public enum EntityStatus
    {
        Active = 1, // dang hoat dong
        Inactive = 2, // KHÔNG HOẠT ĐỘNG

        PendingForConfirmation = 3, // cho xac nhan 
        PendingForApproval = 4, // cho phe duyet
        Locked = 5, // da khoa
        Nam = 6,//Nam
        Nữ = 7,//Nữ
        ABC = 8,// Khác
        HD= 9, //trang thai hoat d
        KHD = 10
    }
}

