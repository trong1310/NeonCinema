using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

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

namespace NeonCinema_Infrastructure.Implement.WorkShift
{
    public class WorkShiftRepository : IWorkShiftRepository
    {
        private readonly NeonCenimaContext _reps;
        private readonly IMapper _maper;

        public WorkShiftRepository(IMapper maper)
        {
            _reps = new NeonCenimaContext();
            _maper = maper;
        }
        public async Task<HttpResponseMessage> CreateWorkShift(NeonCinema_Domain.Database.Entities.WorkShift workshift, CancellationToken cancellationToken)
        {
            try
            {
                if (workshift.WorkDate == DateTime.MinValue || workshift.TimeStar == DateTime.MinValue || workshift.TimeEnd == DateTime.MinValue)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Please enter enough")
                    };
                }
                var findByName = await _reps.WorkShift.FirstOrDefaultAsync(x => x.WorkDate == workshift.WorkDate);
                if (findByName != null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("workshift already exist")
                    };
                }
                var WorkShiftCreate = new NeonCinema_Domain.Database.Entities.WorkShift()
                {
                    WorkShiftID = Guid.NewGuid(),
                    WorkDate = workshift.WorkDate,
                    TimeStar = workshift.TimeStar,
                    Status = EntityStatus.PendingForApproval,
                    EmployeesID = workshift.EmployeesID,
                };
                await _reps.WorkShift.AddAsync(WorkShiftCreate);
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

        public async Task<HttpResponseMessage> DeleteWorkShift(NeonCinema_Domain.Database.Entities.WorkShift workshift, CancellationToken cancellationToken)
        {
            try
            {
                
                var deleObj = await _reps.WorkShift.FirstOrDefaultAsync(x => x.WorkShiftID == x.WorkShiftID);
                if (deleObj == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("WorkShift not found")
                    };
                }
                deleObj.Deleted = true;
                _reps.WorkShift.Update(deleObj);
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

        public async Task<PaginationResponse<WorkShiftDTO>> GetAllWorkShift(WorkShiftViewRequets requets, CancellationToken cancellationToken)
        {
            var query = _reps.WorkShift.Include(x => x.Employees).AsNoTracking();
            if (requets.WorkDate != DateTime.MinValue)
            {
                query = query.Where(x => x.WorkDate.Date == requets.WorkDate.Date);
            }
            var paginationRequest = new PaginationRequest();
            
            var result = await query.PaginateAsync<NeonCinema_Domain.Database.Entities.WorkShift, WorkShiftDTO>(paginationRequest, _maper, cancellationToken);
            result.Data = (from x in result.Data
                           join y in query on
                           x.WorkShiftID equals y.WorkShiftID
                           orderby y.CreatedTime descending
                           select new WorkShiftDTO
                           {
                               WorkShiftID = y.WorkShiftID,
                               TimeStar = y.TimeStar,
                               TimeEnd = y.TimeEnd,
                               Status = y.Status,
                               EmployeesID = y.EmployeesID, 
                           }
                           ).ToList();
            return new PaginationResponse<WorkShiftDTO>
            {
                HasNext = result.HasNext,
                Data = result.Data,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
            };
        }

        public async Task<HttpResponseMessage> UpdateWorkShift(NeonCinema_Domain.Database.Entities.WorkShift workshift, CancellationToken cancellationToken)
        {
            try
            {
                var workshiftt = await _reps.WorkShift.FirstOrDefaultAsync(x => x.WorkShiftID == x.WorkShiftID);
                if (workshiftt == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movie not found")
                    };
                }
                workshift.TimeStar = workshift.TimeStar;
                workshift.Status = workshift.Status;
                workshift.TimeEnd = workshift.TimeEnd;
                workshift.EmployeesID = workshift.EmployeesID;
                workshift.WorkDate = workshift.WorkDate;    
                _reps.WorkShift.Update(workshiftt);
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
