using NeonCinema_Application.DataTransferObject.Employees;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IEmployeesRepository
    {
        Task<PaginationResponse<EmployeesDTO>> GetAllEmployees(EmployessViewRequest requets, CancellationToken cancellationToken);     
        Task<HttpResponseMessage> CreateEmployees(Employees employees, CancellationToken cancellationtoken);
        Task<HttpResponseMessage> UpdateEmployees(Employees employees,CancellationToken cancellationtoken);
        Task<HttpResponseMessage> DeleteEmployees(Employees employees, CancellationToken cancellationtoken);

    }
}
