using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Employees;
using NeonCinema_Application.DataTransferObject.Movie;
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
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Employees
{
    public class EmployeesRepository : IEmployeesRepository
    {

        private readonly NeonCenimaContext _db;
        private readonly IMapper _mapper;
        public EmployeesRepository(IMapper mapper)
        {
            _db = new NeonCenimaContext();
            _mapper = mapper;
        }

        public async Task<HttpResponseMessage> CreateEmployees(NeonCinema_Domain.Database.Entities.Employees employees, CancellationToken cancellationtoken)
        {
            try
            {
                if (employees.EmployeesName == null || employees.PassWord == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Please enter enough")
                    };
                }
                var findByName = await _db.Employees.FirstOrDefaultAsync(x => x.EmployeesName == employees.EmployeesName);
                if (findByName != null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movies already exist")
                    };
                }
                
                await _db.AddAsync(employees);  
                await _db.SaveChangesAsync();
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

        public async Task<HttpResponseMessage> DeleteEmployees(NeonCinema_Domain.Database.Entities.Employees employees, CancellationToken cancellationtoken)
        {
            try
            {
                var deleObj = await _db.Employees.FirstOrDefaultAsync(x => x.EmployeesID == x.EmployeesID);
                if (deleObj == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Movie not found")
                    };
                }
                deleObj.Deleted = true;
                _db.Employees.Update(deleObj);
                await _db.SaveChangesAsync(cancellationtoken);
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

        public async Task<PaginationResponse<EmployeesDTO>> GetAllEmployees(EmployessViewRequest requets, CancellationToken cancellationToken)
        {
            // Xây dựng truy vấn cơ bản với Employee và bao gồm WorkShifts
            var query = _db.Employees.Include(x => x.WorkShifts).AsNoTracking();

            // Kiểm tra nếu EmployeesName không null hoặc chỉ chứa khoảng trắng
            if (!string.IsNullOrWhiteSpace(requets.EmployeesName))
            {
                // Lọc kết quả theo EmployeesName
                query = query.Where(x => x.EmployeesName.Contains(requets.EmployeesName));
            }

            // Tạo đối tượng PaginationRequest từ EmployessViewRequest
            var paginationRequest = new PaginationRequest();
            

            // Sử dụng paginationRequest thay vì requests trong PaginateAsync
            var result = await query.PaginateAsync<NeonCinema_Domain.Database.Entities.Employees, EmployeesDTO>(paginationRequest, _mapper, cancellationToken);

            // Tạo danh sách EmployeesDTO từ kết quả
            result.Data = (from x in result.Data
                           join y in query on
                           x.EmployeesID equals y.EmployeesID
                           orderby y.CreateDate descending
                           select new EmployeesDTO
                           {
                               EmployeesID = y.EmployeesID,
                               EmployeesName = y.EmployeesName, // Đúng tên thuộc tính
                               PassWord = y.PassWord,           // Sửa thành y.PassWord thay vì y.Description
                               PhoneNumber = y.PhoneNumber,     // Sửa thành y.PhoneNumber thay vì y.Status
                               Email = y.Email,
                               Sex = y.Sex,
                               Images = y.Images,
                               DateOrBriht = y.DateOrBriht,
                               Position = y.Position,
                               CreateDate = y.CreateDate,
                           }).ToList();

            // Trả về kết quả phân trang
            return new PaginationResponse<EmployeesDTO>()
            {
                HasNext = result.HasNext,
                Data = result.Data,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
            };
        }
        private async Task<EmployeesDTO> GetById(Guid id, CancellationToken cancellationToken)
        {
            var emp = await _db.Employees.FindAsync(id, cancellationToken);
            return _mapper.Map<EmployeesDTO>(id);
        }
        public async Task<HttpResponseMessage> UpdateEmployees(NeonCinema_Domain.Database.Entities.Employees employees, CancellationToken cancellationtoken)
        {
            try
            {
                var emp = await _db.Employees.FirstOrDefaultAsync(x => x.EmployeesID == employees.EmployeesID);
                if (emp == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    { 
                        Content = new StringContent("Movie not found")
                    };
                }
                emp.EmployeesName = employees.EmployeesName;
                emp.PassWord = employees.PassWord;
                emp.PhoneNumber = employees.PhoneNumber;
                emp.Email = employees.Email;
                emp.Sex = employees.Sex;
                emp.Images = employees.Images;
                emp.CreateDate = employees.CreateDate;
                emp.Position = employees.Position;
                emp.DateOrBriht = employees.DateOrBriht;
                _db.Employees.Update(emp);
                await _db.SaveChangesAsync(cancellationtoken);
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
