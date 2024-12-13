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
    public enum seatEnum
    {
		Available =1  ,  // Ghế còn trống
		Sold =2     ,   // Ghế đã bán
		Selected =3,    // Ghế đã chọn
		Maintenance =4  // Ghế bảo trì
	}
    public enum ticketEnum
    {
        checkin =0,
        waiting_for_payment = 1,
        paid = 2,
        cancel = 3,
    }

    public enum ScreeningStatus
    {
        InActive = 0,
        Showing = 1,
        Ended = 2
    }

}

