using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.SeatTypes
{
    internal class SeatTypeRepository : ISeatTypeRepository
    {
        IMapper _mapper;
        NeonCenimaContext _context;
        public SeatTypeRepository(IMapper mapper, NeonCenimaContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(SeatType input, CancellationToken cancellationToken)
        {
            try
            {
                if (input.SeatTypeName == null || input.Price == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Please enter enough")
                    };
                }

                var seatT = new SeatType()
                {
                    SeatTypeID = Guid.NewGuid(),
                    SeatTypeName = input.SeatTypeName,
                    Price = input.Price
                };

                _context.SeatTypes.Add(seatT);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Add seat type complete")
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

        public async Task<HttpResponseMessage> Delete(SeatType input, CancellationToken cancellationToken)
        {
            try
            {
                var seatT = await _context.SeatTypes.FindAsync(input.SeatTypeID, cancellationToken);

                if (seatT == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Seat type is not found")
                    };
                }

                _context.SeatTypes.Remove(seatT);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete seat type complete")
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

        public async Task<List<SeatTypeDTO>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.SeatTypes
                .ToListAsync(cancellationToken);

            return lst.Select(x => _mapper.Map<SeatTypeDTO>(x)).ToList();
        }

        public async Task<SeatTypeDTO> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var seatT = await _context.SeatTypes.FindAsync(id, cancellationToken);

                if (seatT == null)
                {
                    throw new Exception("seat type is not found");
                }

                return _mapper.Map<SeatTypeDTO>(seatT);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(SeatType input, CancellationToken cancellationToken)
        {
            try
            {
                var seatT = await _context.SeatTypes.FindAsync(input.SeatTypeID);

                if (seatT == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Seat type is not found")
                    };
                }


                seatT.SeatTypeName = input.SeatTypeName;
                seatT.Price = input.Price;


                _context.SeatTypes.Update(seatT);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Update seat type complete")
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
