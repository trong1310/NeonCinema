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

namespace NeonCinema_Infrastructure.Implement.Surcharge
{
    public class SurchargeRepository : IEntityRepository<Surcharges>
    {
        NeonCinemasContext _context;
        public SurchargeRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(Surcharges entity, CancellationToken cancellationToken)
        {
            try
            {
                if (entity.EndTime <= entity.StartTime || entity.StartTime <= DateTime.Now)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Time is not correct")
                    };
                }


                Surcharges sc = new Surcharges
                {
                    ID = Guid.NewGuid(),
                    StartTime = entity.StartTime,
                    EndTime = entity.EndTime,
                    Price = entity.Price,
                    Description = entity.Description,
                    status = EntityStatus.PendingForConfirmation
                };

                _context.Surcharges.Add(sc);
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

        public async Task<HttpResponseMessage> Delete(Surcharges entity, CancellationToken cancellationToken)
        {
            try
            {
                var sc = await _context.Surcharges.FindAsync(entity.ID);

                if (sc == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Surcharge is not found")
                    };
                }

                _context.Surcharges.Remove(sc);
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

        public async Task<List<Surcharges>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.Surcharges.ToListAsync(cancellationToken);

            return lst;
        }

        public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Surcharges> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var sc = await _context.Surcharges.FindAsync(id);

                if (sc == null)
                {
                    throw new Exception("Surcharge is not found");
                }


                return sc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(Surcharges entity, CancellationToken cancellationToken)
        {
            try
            {
                if (entity.EndTime <= entity.StartTime || entity.StartTime <= DateTime.Now)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Time is not correct")
                    };
                }

                var sc = await _context.Surcharges.FindAsync(entity.ID);

                if (sc == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Surcharge is not found")
                    };
                }

                sc.StartTime = entity.StartTime;
                sc.EndTime = entity.EndTime;
                sc.Price = entity.Price;
                sc.Description = entity.Description;
                sc.status = entity.status;

                _context.Surcharges.Update(sc);
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
