using AutoMapper.QueryableExtensions;
using AutoMapper;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NeonCinema_Infrastructure.Extention
{
    public static class QueryableExtensions
    {
        public static async Task<PaginationResponse<TSourceEntity>> PaginateAsync<TSourceEntity>(
          this IQueryable<TSourceEntity> queryable, PaginationRequest request,
          CancellationToken cancellationToken)
        {
            // Force to sort by CreateTime asc 
            IQueryable<TSourceEntity> finalQuery = queryable;

            // Hit to the db to get data back to client side
            var result = await finalQuery
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize + 1)
                .ToListAsync(cancellationToken);

            bool hasNext = result.Count == request.PageSize + 1;

            return new PaginationResponse<TSourceEntity>()
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = result.Take(request.PageSize).ToList()
            };
        }

        public static async Task<PaginationResponse<TTargetEntity>> PaginateAsync<TSourceEntity, TTargetEntity>(
            this IQueryable<TSourceEntity> queryable, PaginationRequest request, IMapper mapper,
            CancellationToken cancellationToken) where TSourceEntity : ICreateBase
        {
            // Force to sort by CreateTime asc 
            IQueryable<TSourceEntity> finalQuery = queryable.OrderByDescending(x => x.CreatedTime);

            // Hit to the db to get data back to client side
            var result = await finalQuery
                .ProjectTo<TTargetEntity>(mapper.ConfigurationProvider)
            .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize + 1)
                .ToListAsync(cancellationToken);

            bool hasNext = result.Count == request.PageSize + 1;

            return new PaginationResponse<TTargetEntity>()
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = result.Take(request.PageSize).ToList()
            };
        }
    }
}
