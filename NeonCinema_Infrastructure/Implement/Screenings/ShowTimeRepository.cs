using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.ShowTime;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Screenings
{
    public class ShowTimeRepository : IShowTimeRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public ShowTimeRepository(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ShowTimeDTO>> GetAllShowTime(CancellationToken cancellationToken)
        {
            var showTimes = await _context.ShowTimes.ToListAsync(cancellationToken);
            return _mapper.Map<List<ShowTimeDTO>>(showTimes);
        }

        public async Task<ShowTimeDTO> GetByIDShowTime(Guid id, CancellationToken cancellationToken)
        {
            var showTime = await _context.ShowTimes.FindAsync(new object[] { id }, cancellationToken);
            return _mapper.Map<ShowTimeDTO>(showTime);
        }

        public async Task<HttpResponseMessage> CreateShowTime(ShowTimeCreateRequest request, CancellationToken cancellationToken)
        {
            var showTime = _mapper.Map<ShowTime>(request);
            await _context.ShowTimes.AddAsync(showTime, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent($"ShowTime with ID {showTime.ID} created.")
            };
        }

        public async Task<HttpResponseMessage> UpdateShowTime(Guid id, ShowTimeUpdateRequest request, CancellationToken cancellationToken)
        {
            var showTime = await _context.ShowTimes.FindAsync(new object[] { id }, cancellationToken);
            if (showTime == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            _mapper.Map(request, showTime);
            _context.ShowTimes.Update(showTime);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent($"ShowTime with ID {id} updated.")
            };
        }

        public async Task<HttpResponseMessage> DeleteShowTime(Guid id, CancellationToken cancellationToken)
        {
            var showTime = await _context.ShowTimes.FindAsync(new object[] { id }, cancellationToken);
            if (showTime == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            _context.ShowTimes.Remove(showTime);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent($"ShowTime with ID {id} deleted.")
            };
        }

        
    }
}
