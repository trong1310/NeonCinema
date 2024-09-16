using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.FoodCombo_R
{
    public class FoodComboRepository : IEntityRepository<FoodCombo>
    {
        NeonCinemasContext _context;
        public FoodComboRepository(NeonCinemasContext context)
        {
            _context = context;
        }

        public async Task<HttpResponseMessage> Create(FoodCombo entity, CancellationToken cancellationToken)
        {
            try
            {
                FoodCombo e = new FoodCombo
                {
                    ID = Guid.NewGuid(),
                    Quantity = entity.Quantity,
                    TotalPrice = entity.TotalPrice,
                    ServiceID = entity.ServiceID,
                    BillID = entity.BillID,
                };

                _context.FoodCombos.Add(e);
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

        public async Task<HttpResponseMessage> Delete(FoodCombo entity, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.FoodCombos.FindAsync(entity.ID);

                if (e == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("FoodCombo is not found")
                    };
                }

                _context.FoodCombos.Remove(e);
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

        public async Task<List<FoodCombo>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.FoodCombos
                .Include(x => x.Bills)
                .Include(x => x.Service)
                .ToListAsync(cancellationToken);

            return lst;
        }

        public async Task<FoodCombo> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.FoodCombos.FindAsync(id);

                if (e == null)
                {
                    throw new Exception("FoodCombo is not found");
                }


                return e;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(FoodCombo entity, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.FoodCombos.FindAsync(entity.ID);

                if (e == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("FoodCombo is not found")
                    };
                }

                e.Quantity = entity.Quantity;
                e.TotalPrice = entity.TotalPrice;
                e.ServiceID = entity.ServiceID;
                e.BillID = entity.BillID;

                _context.FoodCombos.Update(e);
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
    }
}
