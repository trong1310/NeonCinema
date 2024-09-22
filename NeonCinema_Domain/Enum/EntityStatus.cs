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
        PendingForConfirmation = 2, // cho xac nhan 
        PendingForApproval = 3, // cho phe duyet
        Locked = 4, // da khoa
        Men = 5,//Nam
        Girl = 6,//Nữ
        ABC = 7,// Khác

    }
}

