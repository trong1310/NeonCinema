using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Statistics
{
    public class StatisticsDTO
    {
        public decimal DailyRevenue { get; set; }
        public int NewCustomers { get; set; }
        public int TotalTickets { get; set; }
        public decimal TotalRevenue { get; set; }
        public List<FoodCombo> FoodCombos { get; set; }
    }
}
