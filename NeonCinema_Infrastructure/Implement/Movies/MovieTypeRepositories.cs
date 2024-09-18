using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.Interface.Movies;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Movies
{
    public class MovieTypeRepositories : IMovieTypeRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _map;
        public MovieTypeRepositories(IMapper map)
        {
            _context = new NeonCinemasContext();
            _map = map; 
        }
        public async Task<HttpResponseMessage> Create(MovieType movieType, CancellationToken cancellationToken)
        {
            try
            {
                movieType.ID = Guid.NewGuid();
                movieType.CreatedTime = DateTime.Now;
                await _context.MoviesType.AddAsync(movieType);
                await _context.SaveChangesAsync(cancellationToken);
				return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
				{
					Content = new StringContent("Thêm thành công")
				};
			}
            catch(Exception ex) 
            {
				return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
				{
					Content = new StringContent("có lỗi xảy ra"+ex.Message)
				};
			}
        }

        public async Task<HttpResponseMessage> Delete(MovieType movieType, CancellationToken cancellationToken)
        {
			try
			{
				var obj = await _context.MoviesType.FindAsync(movieType.ID);
				if (obj != null)
				{
					movieType.Deleted = true;
					movieType.DeletedTime = DateTime.Now;

				}
				_context.MoviesType.Update(obj);
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

        public async Task<List<MovieTypeDTO>> GetAll(MovieTypeDTO movieTypeDTO, CancellationToken cancellationToken)
        {
			var query = _context.MoviesType.AsNoTracking();
			if (!String.IsNullOrWhiteSpace(movieTypeDTO.MovieTypeName))
			{
				query = query.Where(x => x.MovieTypeName.Contains(movieTypeDTO.MovieTypeName.ToLower()));
			}

			var obj = await query.ToListAsync();
			return _map.Map<List<MovieTypeDTO>>(obj.Where(x => x.Deleted == null));
		}

        public async Task<HttpResponseMessage> Update(MovieType movieType, CancellationToken cancellationToken)
        {
			try
			{
				var obj = await _context.MoviesType.FindAsync(movieType.ID);
				if (obj != null)
				{
					movieType.MovieTypeName = obj.MovieTypeName;
					movieType.ModifiedTime = DateTime.Now;

				}
				_context.MoviesType.Update(obj);
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
					Content = new StringContent("Có lỗi xảy ra"+ex.Message)
				};
			}
		}
    }
}
