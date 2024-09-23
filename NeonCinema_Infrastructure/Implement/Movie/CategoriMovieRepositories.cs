using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.CategoryMovies;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Movie
{
    public class CategoriMovieRepositories : ICategoryMovieRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _map;
        public CategoriMovieRepositories( IMapper map)
        {
            _context = new NeonCinemasContext();
            _map = map;
        }

        public async Task<HttpResponseMessage> Create(CategoryMovies data, CancellationToken cancellationToken)
        {
            try
            {
                data.ID = Guid.NewGuid();
                data.CreatedTime = DateTime.Now;
                await _context.CategoryMovies.AddAsync(data);
                await _context.SaveChangesAsync(cancellationToken);
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

        public async Task<HttpResponseMessage> Delete(CategoryMovies data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.CategoryMovies.FindAsync(data.ID);
                if (obj != null)
                {
                    obj.Status = EntityStatus.Locked;
                    obj.DeletedTime = DateTime.Now;

                }
                _context.CategoryMovies.Update(obj);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Xóa thành công")
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

        public async Task<List<CategoryDTO>> GetAllMovies(CategoryDTO data, CancellationToken cancellationToken)
        {
           var query = _context.CategoryMovies.AsNoTracking();
            var result = await query.ToListAsync();
            return _map.Map<List<CategoryDTO>>(result);
        }

        public async Task<HttpResponseMessage> Update(CategoryMovies data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.CategoryMovies.FindAsync(data.ID);
                if (obj != null)
                {
                    data.MovieID = obj.MovieID;
                    data.MovieTypeID = obj.MovieTypeID;
                    data.ModifiedTime = DateTime.Now;
                }
                _context.CategoryMovies.Update(obj);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Sửa Thành Công")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Có lỗi xảy ra" + ex.Message)
                };
            }
        }
    }
}
