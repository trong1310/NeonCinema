using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BillDetails;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.BillDetails
{
    //public class BillDetailsRepository : IBillDetailsRepository
    //{
    //    IMapper _mapper;
    //    NeonCenimaContext _context;
    //    public BillDetailsRepository(IMapper mapper, NeonCenimaContext context)
    //    {
    //         _mapper = mapper;
    //        _context = context;
    //    }
    //    public async Task<HttpResponseMessage> Create(Bill input, CancellationToken cancellationToken)
    //    {
    //        try
    //        {
    //            if(input.Price == null ||
    //               input.NumberOfProduct == null ||
    //               input.TotalMoney == null)
    //            {
    //                return new HttpResponseMessage(HttpStatusCode.BadRequest)
    //                {
    //                    Content = new StringContent("Please enter enough")
    //                };
    //            }

    //            var billdetails = new Bill()
    //            {
    //                BillDetailID = Guid.NewGuid(),
    //                CustomerID = input.CustomerID,
    //                TicketID = input.TicketID,
    //                PaymentID = input.PaymentID,
    //                ServiceOderID = input.ServiceOderID,
    //                EmployeeID = input.EmployeeID,
    //                PromotionID = input.PromotionID,
    //                Price = input.Price,
    //                NumberOfProduct = input.NumberOfProduct,
    //                SoldDate = DateTime.Now, //Lấy thời gian tại thời điểm tạo 
    //                TotalMoney = input.TotalMoney,
    //                Status = EntityStatus.Active
    //            };

    //            _context.BillDetails.Add(billdetails);
    //            await _context.SaveChangesAsync(cancellationToken);

    //            return new HttpResponseMessage(HttpStatusCode.OK)
    //            {
    //                Content = new StringContent("Add bill complete")
    //            };
    //        }
    //        catch (Exception ex)
    //        {
    //            return new HttpResponseMessage(HttpStatusCode.InternalServerError)
    //            {
    //                Content = new StringContent(ex.Message)
    //            };
    //        }
    //    }

    //    public Task<HttpResponseMessage> Delete(Bill bill, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<List<BillDetailsDTO>> GetAll(CancellationToken cancellationToken)
    //    {
    //        var lst = await _context.BillDetails
    //            .Include(a => a.Customers)
    //            .Include(b => b.Ticket)
    //            .Include(c => c.PaymentMethod)
    //            .Include(d => d.ServiceOder)
    //            .Include(e => e.Employees)
    //            .Include(f => f.Promotion)
    //            .ToListAsync(cancellationToken);


    //        return lst.Select(bill => _mapper.Map<BillDetailsDTO>(bill)).ToList();
    //    }

    //    public async Task<BillDetailsDTO> GetById(Guid id, CancellationToken cancellationToken)
    //    {
    //        try
    //        {
    //            var findbill = await _context.BillDetails.FindAsync(id, cancellationToken);

    //            if(findbill != null)
    //            {
    //                return _mapper.Map<BillDetailsDTO>(findbill);
    //            }
    //            else
    //            {
    //                throw new Exception("Not found");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new NotImplementedException(ex.Message);
    //        }
    //    }

    //    public Task<HttpResponseMessage> Update(Bill bill, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
