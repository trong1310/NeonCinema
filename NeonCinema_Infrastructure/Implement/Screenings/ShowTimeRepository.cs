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
    public class ShowTimeRepository : IEntityRepository<ShowTime>
    {
        NeonCinemasContext _context;

        public ShowTimeRepository(NeonCinemasContext context)
        {
                _context = context;
        }
        public async Task<HttpResponseMessage> Create(ShowTime entity, CancellationToken cancellationToken)
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


                ShowTime st = new ShowTime
                {
                    ID = Guid.NewGuid(),
                    StartTime = entity.StartTime,
                    EndTime = entity.EndTime,
                    Status = EntityStatus.PendingForConfirmation
                };

                _context.ShowTimes.Add(st);
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

        public async Task<HttpResponseMessage> Delete(ShowTime entity, CancellationToken cancellationToken)
        {
            try
            {
                var st = await _context.FindAsync<ShowTime>(entity.ID);

                if (st == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("ShowTime is not found")
                    };
                }

                _context.ShowTimes.Remove(st);
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

        public async Task<List<ShowTime>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.ShowTimes.ToListAsync(cancellationToken);

            return lst;
        }

        public async Task<ShowTime> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var st = await _context.ShowTimes.FindAsync(id);

                if (st == null)
                {
                    throw new Exception("ShowTime is not found");
                }


                return st;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(ShowTime entity, CancellationToken cancellationToken)
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

                var st = await _context.ShowTimes.FindAsync(entity.ID);

                if (st == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("ShowDate is not found")
                    };
                }

                st.StartTime = entity.StartTime;
                st.EndTime = entity.EndTime;
                st.Status = entity.Status;

                _context.ShowTimes.Update(st);
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
