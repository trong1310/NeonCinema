using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Screenings
{
    public class ShowTimeRepository : IEntityRepository<ShowTime>
    {
        public Task<HttpResponseMessage> Create(ShowTime entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Delete(ShowTime entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShowTime>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ShowTime> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Update(ShowTime entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
