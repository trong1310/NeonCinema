﻿using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
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
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public ScreeningRepository(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<HttpResponseMessage> CreateScreening(ScreeningCreateRequest screeningRequest, CancellationToken cancellationToken)
        {
            var screening = _mapper.Map<Screening>(screeningRequest);
            screening.ID = Guid.NewGuid();
            await _context.Screening.AddAsync(screening, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.Created);
        }

        public async Task<HttpResponseMessage> UpdateScreening(ScreeningUpdateRequest screeningRequest, CancellationToken cancellationToken)
        {
            var screening = await _context.Screening.FindAsync(screeningRequest.ID, cancellationToken);
            if (screening == null) return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);

            _mapper.Map(screeningRequest, screening);
            _context.Screening.Update(screening);
            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        public async Task<HttpResponseMessage> DeleteScreening(Guid id, CancellationToken cancellationToken)
        {
            var screening = await _context.Screening.FindAsync(id, cancellationToken);
            if (screening == null) return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);

            _context.Screening.Remove(screening);
            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.NoContent);
        }

        public async Task<List<ScreeningSupportValidate>> GetScrByRoomAndShowDate(Guid roomId, DateTime showDate)
        {
            try
            {
                var lstScr = await _context.Screening.Where(x => x.RoomID == roomId && x.ShowDate == showDate && x.Status != ScreeningStatus.Ended && x.Status != ScreeningStatus.Cancelled).ToListAsync();

                return lstScr.Select(x => _mapper.Map<ScreeningSupportValidate>(x)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<PaginationResponse<ScreeningDTO>> GetAllScreening(ViewScreningRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Screening.Include(x => x.Movies).Include(x => x.ShowTime).Include(x => x.Rooms).AsNoTracking();
            if (request.SearchDate.HasValue)
            {
                query = query.Where(x => x.ShowDate.Equals(request.SearchDate));
            }
            var result = await query.PaginateAsync<Screening, ScreeningDTO>(request, _mapper, cancellationToken);
            var data = (from a in result.Data
                        join b in query on a.ID equals b.ID
                        orderby b.ShowTime.StartTime ascending
                        select new ScreeningDTO
                        {
                            ID = b.ID,
                            ShowTime = b.ShowTime.StartTime,
                            FlimsName = b.Movies.Name,
                            RoomName = b.Rooms.Name,
                            ShowDate = b.ShowDate,
                            Status = b.Status,
                        }).ToList();
            return new PaginationResponse<ScreeningDTO>()
            {
                Data = data,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
            };
        }

        public async Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken)
        {
            var screening = await _context.Screening.FindAsync(id, cancellationToken);
            return _mapper.Map<ScreeningDTO>(screening);
        }

		public async Task<HttpResponseMessage> CreateSSS(SeatShowTimeStatusDTO input, CancellationToken ctoken)
		{
            try
            {
                _context.SeatShowTimeStatuss.Add(_mapper.Map<SeatShowTimeStatus>(input));
                await _context.SaveChangesAsync();

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(ex.Message)
                };
            }
		}
	}
}
