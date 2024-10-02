using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Countrys
{
    public interface ICountryRepository
    {
        public Task<List<CountryDTO>> GetAllRole(CancellationToken cancellationToken);
        public Task<CountryDTO> GetByIDRole(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateRole(CountrysCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateRole(Guid id, CountryUpdateRequest request, CancellationToken cancellationToken);
        
    }
}
