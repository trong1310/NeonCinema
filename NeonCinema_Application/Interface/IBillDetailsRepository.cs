using NeonCinema_Application.DataTransferObject.BillDetails;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IBillDetailsRepository
    {
        Task<HttpResponseMessage> Create(Bill bill, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(Bill bill, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(Bill bill, CancellationToken cancellationToken);
        Task<List<BillDetailsDTO>> GetAll(CancellationToken cancellationToken);
        Task<BillDetailsDTO> GetById(Guid id, CancellationToken cancellationToken);
    }
}
