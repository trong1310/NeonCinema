
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Directors
{
    public interface IDirectorRepositories
    {
        public Task<List<DirectorDTO>> GetAllDirector(CancellationToken cancellationToken);
        public Task<DirectorDTO> GetDirectorById(Guid id, CancellationToken cancellationToken);
        public Task<DirectorDTO> CreateDirector(CreateDirectorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateDirector(Guid id, UpdateDirectorRequest request, CancellationToken cancellationToken);


    }
}
