using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Screenings;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.AutoMapperProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Screenings
{
    public class ScreeningRepository : IScreeningRepository
    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;
        
        public ScreeningRepository(NeonCenimaContext context, IMapper mapper)
        {
            _context = context; 
            _mapper = mapper;
        }
        public async Task<HttpResponseMessage> CreateScreening(Screening screening, CancellationToken cancellationToken)
        {
            try
            {
                var lstScr = GetAllScreening(cancellationToken);
                if (screening.ScreeningDate < DateTime.Now)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Invalid show date")
                    };
                }

                foreach (var item in lstScr.Result)
                {
                    if(item.ScreeningDate == screening.ScreeningDate)
                    {
                        if(screening.StarTime <= item.EndTime || screening.EndTime >= item.StarTime)
                        {
                            return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                            {
                                Content = new StringContent("Showtime or end time clashes with other showtimes")
                            };
                        }
                    }
                }

                var scr = new Screening
                {
                    ScreeningID = Guid.NewGuid(),
                    StarTime = screening.StarTime,
                    EndTime = screening.EndTime,
                    ScreeningDate = screening.ScreeningDate,
                    Price = screening.Price,
                    Status = EntityStatus.PendingForApproval,
                    MovieID = screening.MovieID,
                    RoomID = screening.RoomID
                };

                _context.Screening.Add(scr);

                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Add screening complete")
                };
            }
            catch(Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> DeleteScreening(Screening screening, CancellationToken cancellationToken)
        {
            try
            {
                var scr = await _context.Screening.FindAsync(screening.ScreeningID);

                if(scr == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Screening is not found")
                    };
                }

                _context.Screening.Remove(scr);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete screening complete")
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

        public async Task<List<ScreeningDTO>> GetAllScreening(CancellationToken cancellationToken)
        {
            var lst = await _context.Screening
                .Include(x => x.Movies)
                .Include(x => x.Room)
                .ToListAsync(cancellationToken);

            return lst.Select(scr => _mapper.Map<ScreeningDTO>(scr)).ToList();
        }

        public async Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var scr = await _context.Screening.FindAsync(id);

                if (scr == null)
                {
                    throw new Exception("Screening is not found");
                }

                return _mapper.Map<ScreeningDTO>(scr);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> UpdateScreening(Screening screening, CancellationToken cancellationToken)
        {
            try
            {
                var scr = await _context.Screening.FindAsync(screening.ScreeningID);

                if(scr == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Screening is not found")
                    };
                }

                var lstScr = GetAllScreening(cancellationToken);

                foreach (var item in lstScr.Result)
                {
                    if (item.ScreeningDate == screening.ScreeningDate)
                    {
                        if (screening.StarTime <= item.EndTime || screening.EndTime >= item.StarTime)
                        {
                            return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                            {
                                Content = new StringContent("Showtime or end time clashes with other showtimes")
                            };
                        }
                    }
                }

                if (screening.ScreeningDate < DateTime.Now)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Invalid show date")
                    };
                }

                scr.StarTime = screening.StarTime;
                  scr.EndTime = screening.EndTime;
                  scr.ScreeningDate = screening.ScreeningDate;
                  scr.Price = screening.Price;
                  scr.Status = EntityStatus.PendingForApproval;
                  scr.MovieID = screening.MovieID;
                  scr.RoomID = screening.RoomID;

                _context.Screening.Update(scr);

                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Update screening complete")
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
