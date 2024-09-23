using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Screening;
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

        public async Task<List<ScreeningDTO>> GetAllScreening(CancellationToken cancellationToken)
        {
            var screenings = await _context.Screening.ToListAsync(cancellationToken);
            return _mapper.Map<List<ScreeningDTO>>(screenings);
        }

        public async Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken)
        {
            var screening = await _context.Screening.FindAsync(id, cancellationToken);
            return _mapper.Map<ScreeningDTO>(screening);
        }
    }
}
