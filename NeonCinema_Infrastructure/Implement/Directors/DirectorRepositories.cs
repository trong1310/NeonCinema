using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Directors
{
    public class DirectorRepositories : IDirectorRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _map;
        public DirectorRepositories(IMapper map)
        {
            _map = map;
            _context = new NeonCinemasContext();
        }
        public async Task<HttpResponseMessage> CreateDirector(Director director, CancellationToken cancellationToken)
        {
            try
            {
                director.ID = Guid.NewGuid();
                director.CreatedTime = DateTime.Now;
                director.Status = EntityStatus.Active;
                await _context.Directors.AddAsync(director);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Them Thanh Cong")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Co Loi xay ra" + ex.Message)
                };
            }

        }

        public async Task<HttpResponseMessage> DeleteDirector(Director director, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Directors.FirstOrDefaultAsync(x => x.ID == director.ID);
                if (obj == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("không tìm thấy")
                    };
                }
                else
                {
                    obj.DeletedTime = DateTime.UtcNow;
                    obj.Status = EntityStatus.Locked;
                    _context.Directors.Update(obj);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                    {
                        Content = new StringContent("xóa thành công")
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

        public async Task<List<DirectorDTO>> GetAllDirector(ViewDirectorRequest request, CancellationToken cancellationToken)
        {
            var query =  _context.Directors.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(request.SearchName)) 
            {
                query =  query.Where(x => x.FullName.Contains(request.SearchName.ToLower()));
            }
            var obj = await query.ToListAsync();
            return _map.Map < List<DirectorDTO>>(obj);
        }

        public async Task<HttpResponseMessage> UpdateDirector(Director director, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Directors.FirstOrDefaultAsync(x => x.ID == director.ID);
                if (obj != null)
                {
                    director.ModifiedTime = DateTime.UtcNow;
                    obj.Status = director.Status;
                    obj.FullName = director.FullName;
                    obj.Address = director.Address;
                    obj.Gender = director.Gender;
                    obj.Biography = director.Biography;
                    obj.Images = director.Images;
                    obj.Nationality = director.Nationality;

                    _context.Directors.Update(obj);
                    await _context.SaveChangesAsync(cancellationToken);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                    {
                        Content = new StringContent("Sửa thành công")
                    };
                }
                else
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Không tìm thấy")
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
