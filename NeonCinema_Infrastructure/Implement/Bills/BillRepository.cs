using AutoMapper;
using Bogus;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Bills
{
    public class BillRepository : IEntityRepository<Bill>
    {
        NeonCinemasContext _context;
        private readonly IMapper _map;
        public BillRepository(NeonCinemasContext context , IMapper map)
        {
            _context = context;
            _map = map;
        }

        public async Task<HttpResponseMessage> Create(Bill entity, CancellationToken cancellationToken)
        {
            try
            {
                Bill bill = new Bill
                {
                    ID = Guid.NewGuid(),
                    UserID = entity.UserID,
                    TotalPrice = entity.TotalPrice,
                    QrCode = entity.QrCode,
                    Status = EntityStatus.Active
                };

                _context.BillDetails.Add(bill);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Create successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> Delete(Bill entity, CancellationToken cancellationToken)
        {
            try
            {
                var bill = await _context.BillDetails.FindAsync(entity.ID);

                if (bill == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Bill is not found")
                    };
                }

                _context.BillDetails.Remove(bill);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<List<Bill>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.BillDetails
                .Include(x => x.Users)
                .ToListAsync(cancellationToken);

            return lst;
        }

        public async Task<Bill> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var bill = await _context.BillDetails.FindAsync(id);

                if (bill == null)
                {
                    throw new Exception("Bill is not found");
                }


                return bill;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(Bill entity, CancellationToken cancellationToken)
        {
            try
            {
                var bill = await _context.BillDetails.FindAsync(entity.ID);

                if (bill == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Bill is not found")
                    };
                }
                bill.UserID = entity.UserID;
                bill.TotalPrice = entity.TotalPrice;
                bill.QrCode = entity.QrCode;
                bill.Status = entity.Status;
                _context.BillDetails.Update(bill);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Update successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken)
        {
           var bill = _context.BillDetails.Where(x=>x.UserID== userID).Select(x=> new BillDTO
           {
                TotalPrice = x.TotalPrice,
                Status = x.Status,
                OderDate = x.CreatedTime,
                UserID = userID,
                ID = x.ID

            }).ToList();
            return bill;
        }
    }
}
