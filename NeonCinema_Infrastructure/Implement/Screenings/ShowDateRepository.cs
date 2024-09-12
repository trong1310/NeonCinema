using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Screenings
{
    public class ShowDateRepository : IEntityRepository<ShowDate>
    {
        NeonCinemasContext _context;
        IMapper _mapper;
        public ShowDateRepository(IMapper mapper, NeonCinemasContext context) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<HttpResponseMessage> Create(ShowDate entity, CancellationToken cancellationToken)
        {
            try
            {
                ShowDate sd = new ShowDate
                {
                    ID = Guid.NewGuid(),
                    StarDate = entity.StarDate,
                    Status = EntityStatus.PendingForConfirmation
                };

                _context.ShowDate.Add(sd);
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

        public async Task<HttpResponseMessage> Delete(ShowDate entity, CancellationToken cancellationToken)
        {
            try
            {
                var sd = await _context.FindAsync<ShowDate>(entity.ID);

                if(sd == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("ShowDate is not found")
                    };
                }

                _context.ShowDate.Remove(sd);
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

        public async Task<List<ShowDate>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.ShowDate.Include(x => x.Screening).ToListAsync(cancellationToken);

            return lst;
        }

        public async Task<ShowDate> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var sd = await _context.FindAsync<ShowDate>(id);

                if (sd == null)
                {
                    throw new Exception("ShowDate is not found");
                }


                return sd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(ShowDate entity, CancellationToken cancellationToken)
        {
            try
            {
                var sd = await _context.FindAsync<ShowDate>(entity.ID);

                if (sd == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("ShowDate is not found")
                    };
                }

                sd.StarDate = entity.StarDate;
                sd.Status = entity.Status;

                _context.ShowDate.Update(sd);
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
