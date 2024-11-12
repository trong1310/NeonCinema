using NeonCinema_Application.DataTransferObject.FoodCombos;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.StaticStatis
{
    public class ChartDataResponse
    {
        public List<string> Dates { get; set; } = new();
        public List<decimal> Revenue { get; set; } = new();
        public int TotalTicketsSold { get; set; }
        public decimal TotalRevenue { get; set; }

    }
}
