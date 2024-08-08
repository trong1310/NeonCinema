using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.PromotionCustomer
{
    public class PromotionCustomerRepo : IPromotionCustomerRepository
    {
        private readonly NeonCenimaContext _context;
        public PromotionCustomerRepo(NeonCenimaContext context)
        {
            _context = context;
        }
        
    }
}
