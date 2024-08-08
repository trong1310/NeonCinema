using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IBillRepository
    {
        public Task<List<BillDTO>> GetAll(CancellationToken cancellationToken);
        public Task<BillDTO> GetBillById(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Create(Bill bill, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> Delete(Bill bill, CancellationToken cancellationToken);
    }
}
