using NeonCinema_Application.DataTransferObject.Actors;
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
        public Task<List<DirectorDTO>> GetAllDirector( CancellationToken cancellationToken);
        public Task<DirectorDTO> GetBiIdDirector( Guid id, CancellationToken cancellationToken);
        public Task<DirectorDTO> CreateDirector(CreateDirectorRequest director, CancellationToken cancellationToken);
        public Task<HttpRequestMessage> UpdateDirector(Guid id,UpdateDirectorRequest director, CancellationToken cancellationToken);
        
    }
}
