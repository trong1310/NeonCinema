using NeonCinema_Application.DataTransferObject.Roles;
using NeonCinema_Application.DataTransferObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Roles
{
    public interface IRolesRepository
    {
        public Task<List<RolesDTO>> GetAllRole(CancellationToken cancellationToken);
        public Task<RolesDTO> GetByIDRole(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateRole(RolesCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateRole(Guid id, RolesUpdateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteRole(Guid id, CancellationToken cancellationToken);
    }
}
