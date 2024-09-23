using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Actors
{
    public class ActorRepositories : IActorRepositories
    {
       private readonly  NeonCinemasContext _context;
       private readonly IMapper _map;
        public ActorRepositories(IMapper map)
        {
            _map = map;
            _context = new NeonCinemasContext();
        }
        public async Task<HttpResponseMessage> CreateActor(Actor actor, CancellationToken cancellationToken)
        {

            try
            {
                actor.ID = Guid.NewGuid();
                actor.CreatedTime = DateTime.UtcNow;
                actor.Status = EntityStatus.Active;
                await _context.Actors.AddAsync(actor);
                await _context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Them Thanh Cong")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Co Loi xay ra" +ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> DeleteActor(Actor actor, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetActorByID(actor.ID,cancellationToken);
                if (obj == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy diễn viên")
                    };
                }
                else
                {
                    obj.DeletedTime = DateTime.UtcNow;
                    obj.Status = EntityStatus.Locked;
                    _context.Actors.Update(obj);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                    {
                        Content = new StringContent("Sửa thành công")
                    };
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Có lỗi" + ex.Message)
                };
            }

        }

        private async Task<Actor> GetActorByID(Guid id, CancellationToken cancellationToken)
        {
           var actor =await _context.Actors.FirstOrDefaultAsync(x=>x.ID == id);
            return actor;
        }

        public async Task<List<ActorDTO>> GetAllActor(ViewActorRequest request,  CancellationToken cancellationToken)
        {
            var query = _context.Actors.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(request.SearchName))
            {
                query = query.Where(x=>x.FullName.Contains(request.SearchName.ToLower()));
            }

            var actor = await query.ToListAsync();
            return _map.Map<List<ActorDTO>>(actor);
        }

        public async Task<HttpResponseMessage> UpdateActor(Actor actor, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetActorByID(actor.ID,cancellationToken);

                if (obj == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy diễn viên")
                    };
                }
                else
                {
                    actor.ModifiedTime = DateTime.UtcNow;
                    obj.Status = actor.Status;
                    obj.FullName = actor.FullName;
                    obj.Address = actor.Address;
                    obj.Gender = actor.Gender;
                    obj.Biography = actor.Biography;
                    obj.Images = actor.Images;
                    obj.Nationality = actor.Nationality;
                    
                    _context.Actors.Update(obj);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                    {
                        Content = new StringContent("Sửa thành công")
                    };
                }
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
