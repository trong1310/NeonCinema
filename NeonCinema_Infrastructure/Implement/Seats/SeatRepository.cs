using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Seats;
using AutoMapper;
using System.Threading;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using Com.CloudRail.SI.ServiceCode.Commands;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Infrastructure.Extention;

namespace NeonCinema_Infrastructure.Implement.Seats
{
    public class SeatRepository : ISeatRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _maps;
        public SeatRepository(IMapper maps, NeonCinemasContext context)
        {
            _context = context;
            _maps = maps;
        }

       
        public async Task<HttpResponseMessage> AddAsync(CreateSeatDTO request, CancellationToken cancellationToken)
        {
            try
            {
                var seats = new Seat()
                {
                    ID = Guid.NewGuid(),
                    SeatNumber = request.SeatNumber,
                    Column = request.Column,
                    Row = request.Row,
                    Status = request.Status,
                    RoomID = request.RoomID,
                    SeatTypeID = request.SeatTypeID,


                };
                await _context.Seat.AddAsync(seats);
                await _context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Thêm thành công")

                };
            }
            catch (Exception ex)
            {

                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> DeleteAsync(Seat request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Seat.FirstOrDefaultAsync(x => x.ID == request.ID);
                if (obj != null)
                {
                    obj.Deleted = true;
                    obj.DeletedTime = DateTime.Now;
                    _context.Seat.Update(obj);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                    {
                        Content = new StringContent("Đã xóa thành công")
                    };

                }
                else
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy phim")
                    };
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
                };
            }
        }

        public async Task<PaginationResponse<SeatDTO>> GetAllAsync(ViewSeatRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Seat.Include(x => x.Room).Include(x => x.SeatTypes).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(request.search))
            {
                query = query.Where(x => x.SeatNumber.Contains(request.search.ToLower()));
            }
            var result = await query.PaginateAsync<Seat, SeatDTO>(request, _maps, cancellationToken);
            var dataview = (from a in result.Data
                            join b in query on a.ID equals b.ID
                            orderby b.Row
                            select new SeatDTO
                            {
                                ID = b.ID,
                                SeatNumber = b.SeatNumber,
                                Column = b.Column,
                                Status = b.Status,
                                RoomName = b.Room.Name,
                                SeatTypeName = b.SeatTypes.SeatTypeName
                            }).ToList();
            return new PaginationResponse<SeatDTO>()
            {
                Data = dataview,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize
            };
        }

        public async Task<SeatDTO> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var seat = await _context.Seat.Include(x => x.Room).Include(x => x.SeatTypes).AsNoTracking().FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
            if (seat == null)
            {
                return null;
            }
            var seatdto = new SeatDTO
            {
                ID = seat.ID,
                SeatNumber = seat.SeatNumber,
                Column = seat.Column,
                Status = seat.Status,
                RoomName = seat.Room.Name,
                SeatTypeName = seat.SeatTypes.SeatTypeName
            };
            return seatdto;
        }

        public async Task<HttpResponseMessage> UpdateAsync(Seat request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Seat.FirstOrDefaultAsync(x => x.ID == request.ID);
                if (obj.Deleted == true && obj == null)
                {

                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy phim")
                    };
                }
                request.SeatNumber = obj.SeatNumber;
                request.Column = obj.Column;
                request.Status = obj.Status;
                request.Row = obj.Row;
                request.Status = obj.Status;
                request.RoomID = obj.RoomID;
                request.SeatTypeID = obj.SeatTypeID;
                
                _context.Seat.Update(obj);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Sửa thành công")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
                };
            }
        }
    }
}