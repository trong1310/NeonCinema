using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Roles;
using NeonCinema_Application.Interface.Roles;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Roles
{
    public class RoleRepository : IRolesRepository
    {
        private readonly NeonCinemasContext _context;
        public RoleRepository(NeonCinemasContext ct)
        {
            _context = ct;
        }
        public async Task<HttpResponseMessage> CreateRole(RolesCreateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra không được để trống RoleName
            if (string.IsNullOrWhiteSpace(request.RoleName))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Role name is required.")
                };
            }

            // Kiểm tra trùng dữ liệu cũ (dựa trên RoleName)
            var existingRole = await _context.Roles
                .FirstOrDefaultAsync(r => r.RoleName == request.RoleName, cancellationToken);

            if (existingRole != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("Role with the same name already exists.")
                };
            }

            // Tạo mới role
            var newRole = new NeonCinema_Domain.Database.Entities.Roles 
            {
                ID = request.ID != Guid.Empty ? request.ID : Guid.NewGuid(),
                RoleName = request.RoleName,
                Status = request.Status
            };

            // Thêm vào context và lưu thay đổi
            _context.Roles.Add(newRole);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Role created successfully.")
            };
        }

        public Task<HttpResponseMessage> DeleteRole(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RolesDTO>> GetAllRole(CancellationToken cancellationToken)
        {
            var roles = await _context.Roles
                .Select(r => new RolesDTO
                {
                    ID = r.ID,
                    RoleName = r.RoleName,
                    Status = r.Status
                })
                .ToListAsync(cancellationToken);

            return roles;
        }

        public async Task<RolesDTO> GetByIDRole(Guid id, CancellationToken cancellationToken)
        {
            var role = await _context.Roles
        .Where(r => r.ID == id)
        .Select(r => new RolesDTO
        {
            ID = r.ID,
            RoleName = r.RoleName,
            Status = r.Status
        })
        .FirstOrDefaultAsync(cancellationToken);

            if (role == null)
            {
                throw new KeyNotFoundException("Role not found.");
            }

            return role;
        }

        public async Task<HttpResponseMessage> UpdateRole(Guid id, RolesUpdateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra xem role với ID đã cho có tồn tại hay không
            var existingRole = await _context.Roles
                .FirstOrDefaultAsync(r => r.ID == id, cancellationToken);

            if (existingRole == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Role not found.")
                };
            }

            // Kiểm tra không được để trống RoleName
            if (string.IsNullOrWhiteSpace(request.RoleName))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Role name is required.")
                };
            }

            // Kiểm tra nếu RoleName mới có bị trùng với dữ liệu cũ không
            var roleWithSameName = await _context.Roles
                .FirstOrDefaultAsync(r => r.RoleName == request.RoleName && r.ID != id, cancellationToken);

            if (roleWithSameName != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("Role with the same name already exists.")
                };
            }

            // Cập nhật thông tin role
            existingRole.RoleName = request.RoleName;
            existingRole.Status = request.Status;

            // Lưu thay đổi vào database
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Role updated successfully.")
            };
        }
    }
}
