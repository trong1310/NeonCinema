using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Seats
{
    internal class SeatRepository : ISeatRepository
    {
        IMapper _mapper;
        NeonCenimaContext _context;
        public SeatRepository(IMapper mapper, NeonCenimaContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(Seat input, CancellationToken cancellationToken)
        {
            try
            {
                if (input.SeatNumber == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Please enter enough")
                    };
                }

                var seat = new Seat()
                {
                    SeatID = Guid.NewGuid(),
                    SeatNumber = input.SeatNumber,
                    SeatTypeID = input.SeatTypeID,
                    RoomID = input.RoomID,
                };

                _context.Seat.Add(seat);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Add seat complete")
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

        public async Task<HttpResponseMessage> Delete(Seat input, CancellationToken cancellationToken)
        {
            try
            {
                var seat = await _context.Seat.FindAsync(input.SeatID, cancellationToken);

                if (seat == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Seat is not found")
                    };
                }

                _context.Seat.Remove(seat);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete seat complete")
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

        public async Task<List<SeatDTO>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.Seat
                .Include(x => x.Room)
                .Include(x => x.SeatType)
                .ToListAsync(cancellationToken);

            return lst.Select(x => _mapper.Map<SeatDTO>(x)).ToList();
        }

        public async Task<SeatDTO> GetById(Guid id, Guid roomid, CancellationToken cancellationToken)
        {
            try
            {
                var seat = await _context.Seat.FirstOrDefaultAsync(x => x.SeatID == id && x.RoomID == roomid, cancellationToken);

                if (seat == null)
                {
                    throw new Exception("seat is not found");
                }

                return _mapper.Map<SeatDTO>(seat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<HttpResponseMessage> Update(Seat input, CancellationToken cancellationToken)
        {
            try
            {
                var seat = await _context.Seat.FindAsync(input.SeatID);

                if (seat == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Seat is not found")
                    };
                }


                seat.SeatNumber = input.SeatNumber;
                seat.SeatTypeID = input.SeatTypeID;
                seat.RoomID = input.RoomID;

                _context.Seat.Update(seat);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Update seat complete")
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
