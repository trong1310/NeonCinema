using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IEntityRepository<T> where T : class
    {
        Task<HttpResponseMessage> Create(T entity, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(T entity, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(T entity, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
        public List<BillDTO> GetBillByUser(Guid userID, CancellationToken cancellationToken);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
    }
}
