using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Acotr
{
    public class ActorResp
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _map;
        public ActorResp(NeonCinemasContext context, IMapper mapper)
        {
            _map = mapper;
            _context = context;
        }
        public async Task<PaginationResponse<ActorDTO>> Get(ViewActorRequest actor, CancellationToken cancellationToken)
        {
            var query = _context.Actor.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(actor.SearchName))
            {
                query = query.Where(x => x.Name.Contains(actor.SearchName.Trim().ToLower()));
            }
            var results = await query.PaginateAsync<Actor, ActorDTO>(actor, _map, cancellationToken);
            var data = (from a in results.Data
                        join b in query on a.ID
                        equals b.ID
                        select new ActorDTO
                        {
                            ID = b.ID,
                            FullName = b.Name,
                            Status = b.Status,
                        }).ToList();
            return new PaginationResponse<ActorDTO>
            {
                Data = data,
                HasNext = results.HasNext,
                PageNumber = results.PageNumber,
                PageSize = results.PageSize
            };

        }
        public async Task<HttpResponseMessage> CreateActor(CreateActorRequest actor, CancellationToken cancellationToken)
        {
            try
            {
                var actornew = new Actor()
                {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTime.UtcNow,
                    Name = actor.FullName,
                    Status = actor.Status,
                };
                await _context.Actor.AddAsync(actornew);
                await _context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Thêm thành công")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Có lỗi" + ex.Message)
                };
            }

        }
    }
}
