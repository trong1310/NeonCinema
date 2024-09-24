using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.DataTransferObject.ShowDate;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.ShowDate;
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
    public class ShowDateRepository : IShowDateRepository
    {
        NeonCinemasContext _context;
        IMapper _mapper;
        public ShowDateRepository(IMapper mapper, NeonCinemasContext context) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ShowDateDTO>> GetAllShiftChange(CancellationToken cancellationToken)
        {
            var showDates = await _context.ShowDate.ToListAsync(cancellationToken);
            return _mapper.Map<List<ShowDateDTO>>(showDates);
        }

        public async Task<ShowDateDTO> GetByIDShiftChange(Guid id, CancellationToken cancellationToken)
        {
            var showDate = await _context.ShowDate.FindAsync(new object[] { id }, cancellationToken);
            return _mapper.Map<ShowDateDTO>(showDate);
        }

        public async Task<HttpResponseMessage> CreateShiftChange(ShowDateCreateRequest request, CancellationToken cancellationToken)
        {
            var showDate = _mapper.Map<ShowDate>(request);
            await _context.ShowDate.AddAsync(showDate, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent($"ShowDate with ID {showDate.ID} created.")
            };
        }

        public async Task<HttpResponseMessage> UpdateShiftChange(Guid id, ShowDateUpdateRequest request, CancellationToken cancellationToken)
        {
            var showDate = await _context.ShowDate.FindAsync(new object[] { id }, cancellationToken);
            if (showDate == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            _mapper.Map(request, showDate);
            _context.ShowDate.Update(showDate);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent($"ShowDate with ID {id} updated.")
            };
        }

        public async Task<HttpResponseMessage> DeleteShiftChange(Guid id, CancellationToken cancellationToken)
        {
            var showDate = await _context.ShowDate.FindAsync(new object[] { id }, cancellationToken);
            if (showDate == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            _context.ShowDate.Remove(showDate);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent($"ShowDate with ID {id} deleted.")
            };
        }
    }
}
