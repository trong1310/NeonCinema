using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.ShiftChanges;
using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.ShiftChanges
{
    public class ShiftChangesRepository : IShiftChangeRepository
    {
        private readonly NeonCenimaContext _reps;
        private readonly IMapper _maper;

        public ShiftChangesRepository(IMapper maper)
        {
            _reps = new NeonCenimaContext();
            _maper = maper;
        }
        public async Task<HttpResponseMessage> CreateShiftChanges(ShiftChange shiftChange, CancellationToken cancellationToken)
        {
            try
            {
                if (shiftChange.ShiftName == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Please enter enough")
                    };
                }
                var findByName = await _reps.ShiftChange.FirstOrDefaultAsync(x => x.ShiftName == shiftChange.ShiftName);
                if (findByName != null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("workshift already exist")
                    };
                }
                var ShiftchangesCreate = new NeonCinema_Domain.Database.Entities.ShiftChange()
                {
                    ShiftChangeID = Guid.NewGuid(),
                    ShiftName = shiftChange.ShiftName,
                    NewShift = shiftChange.NewShift,
                    Status = EntityStatus.PendingForApproval,
                    RequetDate = shiftChange.RequetDate,
                    WorkShiftID = shiftChange.WorkShiftID,
                };
                await _reps.ShiftChange.AddAsync(ShiftchangesCreate);
                await _reps.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Created successfully")
                };


            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> DeleteShiftChanges(ShiftChange shiftChange, CancellationToken cancellationToken)
        {
            try
            {
                var deleObj = await _reps.ShiftChange.FirstOrDefaultAsync(x => x.ShiftChangeID == x.ShiftChangeID);
                if (deleObj == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movie not found")
                    };
                }
                deleObj.Deleted = true;
                _reps.ShiftChange.Update(deleObj);
                await _reps.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Deleted successfully")
                };

            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<PaginationResponse<ShiftChangesDTO>> GetAllShiftChanges(ShiftChangesViewRequets requets, CancellationToken cancellationToken)
        {
            var query = _reps.ShiftChange.Include(x => x.WorkShift).AsNoTracking();
            if (!String.IsNullOrWhiteSpace(requets.ShiftName))
            {
                query = query.Where(x => x.ShiftName.Contains(requets.ShiftName));
            }
            var paginationRequest = new PaginationRequest();
           
            var result = await query.PaginateAsync<NeonCinema_Domain.Database.Entities.ShiftChange, ShiftChangesDTO>(paginationRequest, _maper, cancellationToken);
            result.Data = (from x in result.Data
                           join y in query on
                           x.ShiftChangeID equals y.ShiftChangeID
                           orderby y.CreatedTime descending
                           select new ShiftChangesDTO
                           {
                               ShiftChangeID = y.ShiftChangeID,
                               ShiftName = y.ShiftName,
                               NewShift = y.NewShift,
                               Status = y.Status,
                               RequetDate = y.RequetDate,
                               WorkShiftID = y.WorkShiftID,
                           }
                           ).ToList();
            return new PaginationResponse<ShiftChangesDTO>
            {
                HasNext = result.HasNext,
                Data = result.Data,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
            };
        }
        private async Task<ShiftChangesDTO> GetById(Guid id, CancellationToken cancellationToken)
        {
            var shiftchanges = await _reps.ShiftChange.FindAsync(id, cancellationToken);
            return _maper.Map<ShiftChangesDTO>(id);
        }
        public async Task<HttpResponseMessage> UpdateShiftChanges(ShiftChange shiftChange, CancellationToken cancellationToken)
        {
            try
            {
                var shift = await _reps.ShiftChange.FirstOrDefaultAsync(x => x.ShiftChangeID == shiftChange.ShiftChangeID);
                if (shift == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movie not found")
                    };
                }
                shift.ShiftName = shiftChange.ShiftName;
                shift.Status = shiftChange.Status;
                shift.NewShift = shiftChange.NewShift;
                shift.RequetDate = shiftChange.RequetDate;
                shift.WorkShiftID = shiftChange.WorkShiftID;
                
                _reps.ShiftChange.Update(shift);
                await _reps.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Updated successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }
    }
}
