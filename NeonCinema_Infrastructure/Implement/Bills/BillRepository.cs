using AutoMapper;
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
    internal class BillRepository : IBillRepository
    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;
        public BillRepository(NeonCenimaContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(Bill bill, CancellationToken cancellationToken)
        {
            try
            {
                if(bill.TotalMoney == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Total amount cannot be left blank")
                    };
                }

                var b = new Bill
                {
                    BillID = Guid.NewGuid(),
                    SoldDate = DateTime.Now,
                    TotalMoney = bill.TotalMoney,
                    Status = EntityStatus.Active
                };

                _context.Bills.Add(bill);

                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Add bill complete")
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

        public Task<HttpResponseMessage> Delete(Bill bill, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BillDTO>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.Bills.ToListAsync(cancellationToken);

            return lst.Select(bill => _mapper.Map<BillDTO>(bill)).ToList();
        }

        public async Task<BillDTO> GetBillById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var bill = await _context.Bills.FindAsync(id, cancellationToken);
                if (bill == null)
                {
                    throw new Exception("Bill is not found");
                }

                return _mapper.Map<BillDTO>(bill);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
