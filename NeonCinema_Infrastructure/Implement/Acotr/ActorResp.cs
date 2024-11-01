//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.EntityFrameworkCore;
//using NeonCinema_Application.DataTransferObject.Actors;
//using NeonCinema_Application.DataTransferObject.Directors;
//using NeonCinema_Application.Interface.Actors;
//using NeonCinema_Domain.Database.Entities;
//using NeonCinema_Infrastructure.Database.AppDbContext;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace NeonCinema_Infrastructure.Implement.Acotr
//{
//    public class ActorResp : IActorRepositories
//    {
//        private readonly NeonCinemasContext _context;
//        public ActorResp(NeonCinemasContext context)
//        {
//            _context = context;
//        }
//        public async Task<ActorDTO> CreateActor(CreateActorRequest request, CancellationToken cancellationToken)
//        {

//            var actor = new Actor
//            {
//                ID = new Guid(),
//                Name = request.FullName,
//                Status = request.Status,
//            };
//            await _context.Actor.AddAsync(actor);
//            await _context.SaveChangesAsync();
//            var actordto = new ActorDTO
//            {
//                ID = actor.ID,
//                FullName = actor.Name,
//                Status = actor.Status
//            };

//            return actordto;
//        }

//        public async Task<HttpResponseMessage> DeleteActor(DeleteActorRequest request, CancellationToken cancellationToken)
//        {
//            var response = new HttpResponseMessage();

//            try
//            {
//                var actor = await _context.Actor.FindAsync(new object[] { request.ID }, cancellationToken);
//                if (actor == null)
//                {
//                    response.StatusCode = HttpStatusCode.NotFound;
//                    response.Content = new StringContent("Actor not found.");
//                    return response;
//                }
//                _context.Actor.Remove(actor);
//                await _context.SaveChangesAsync(cancellationToken);
//                response.StatusCode = HttpStatusCode.OK;
//                response.Content = new StringContent("Actor deleted successfully.");
//            }
//            catch (Exception ex)
//            {
//                response.StatusCode = HttpStatusCode.InternalServerError;
//                response.Content = new StringContent($"Error deleting actor: {ex.Message}");
//            }
//            return response;
//        }

//        public async Task<ActorDTO> GetActorById(Guid id, CancellationToken cancellationToken)
//        {
//            var ac = await _context.Actor.FindAsync(new object[] { id }, cancellationToken);
//            if (ac == null)
//            {
//                return null;
//            }
//            var actordto = new ActorDTO
//            {
//                ID = ac.ID,
//                FullName = ac.Name,             
//                Status = ac.Status
//            };
//            return actordto;
//        }
//        public async Task<List<ActorDTO>> GetAllActor(CancellationToken cancellationToken)
//        {
//           var actor = await _context.Actor.ToListAsync(cancellationToken);
//            var actordto = actor.Select(ac => new ActorDTO
//            {
//                ID = ac.ID,
//                FullName = ac.Name,               
//                Status = ac.Status
//            }).ToList();
//            return actordto;
//        }
//        public async Task<HttpResponseMessage> UpdateActor(Guid id, UpdateActorRequest request, CancellationToken cancellationToken)
//        {
//            var ac = await _context.Actor.FindAsync(new object[] { id }, cancellationToken);
//            if (ac == null)
//            {
//                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
//                {
//                    Content = new StringContent("director not found.")
//                };
//            }
//            ac.Name = request.FullName;
//            ac.Status = request.Status;
//            await _context.SaveChangesAsync(cancellationToken);
//            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
//            {
//                Content = new StringContent("director updated successfully.")
//            };
//        }
//    }
//}
