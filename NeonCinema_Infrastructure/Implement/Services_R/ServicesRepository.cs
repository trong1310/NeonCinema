using Bogus.DataSets;
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

namespace NeonCinema_Infrastructure.Implement.Services_R
{
    public class ServicesRepository : IEntityRepository<Service>
    {
        NeonCinemasContext _context;
        public ServicesRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(Service entity, CancellationToken cancellationToken)
        {
            try
            {
                Service e = new Service
                {
                    ID = Guid.NewGuid(),
                    ServiceName = entity.ServiceName,
                    Price = entity.Price,
                    Status = EntityStatus.Active,
                    Description = entity.Description,
                    Images = entity.Images
                };

                _context.Service.Add(e);
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

        public async Task<HttpResponseMessage> Delete(Service entity, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.Service.FindAsync(entity.ID);

                if (e == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Service is not found")
                    };
                }

                _context.Service.Remove(e);
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

        public async Task<List<Service>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.Service
                .ToListAsync(cancellationToken);

            return lst;
        }

        public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Service> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.Service.FindAsync(id);

                if (e == null)
                {
                    throw new Exception("Service is not found");
                }


                return e;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(Service entity, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.Service.FindAsync(entity.ID);

                if (e == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Service is not found")
                    };
                }

                e.ServiceName = entity.ServiceName;
                e.Price = entity.Price;
                e.Status = EntityStatus.Active;
                e.Description = entity.Description;
                e.Images = entity.Images;

                _context.Service.Update(e);
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
