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
        public Task<List<DirectorDTO>> GetAllDirector(ViewDirectorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateDirector(Director director, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateDirector(Director director, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteDirector(Director director, CancellationToken cancellationToken);
    }
}
