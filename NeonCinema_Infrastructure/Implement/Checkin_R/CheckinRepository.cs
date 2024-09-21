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

namespace NeonCinema_Infrastructure.Implement.Checkin_R
{
    public class CheckinRepository : IEntityRepository<Checkin>
    {
        NeonCinemasContext _context;
        public CheckinRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(Checkin entity, CancellationToken cancellationToken)
        {
            try
            {
                Checkin e = new Checkin
                {
                    ID = Guid.NewGuid(),
                    Code = entity.Code,
                    Type = entity.Type,
                    Name = entity.Name
                };

                _context.Checkin.Add(e);
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

        public async Task<HttpResponseMessage> Delete(Checkin entity, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.Checkin.FindAsync(entity.ID);

                if (e == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Checkin is not found")
                    };
                }

                _context.Checkin.Remove(e);
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

        public async Task<List<Checkin>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.Checkin.ToListAsync(cancellationToken);

            return lst;
        }

        public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Checkin> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.Checkin.FindAsync(id);

                if (e == null)
                {
                    throw new Exception("Checkin is not found");
                }


                return e;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(Checkin entity, CancellationToken cancellationToken)
        {
            try
            {
                var e = await _context.Checkin.FindAsync(entity.ID);

                if (e == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Checkin is not found")
                    };
                }

                e.Code = entity.Code;
                e.Type = entity.Type;
                e.Name = entity.Name;

                _context.Checkin.Update(e);
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
