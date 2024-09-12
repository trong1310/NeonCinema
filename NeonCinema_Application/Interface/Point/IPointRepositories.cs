using NeonCinema_Application.DataTransferObject.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Point
{
    public interface IPointRepositories
    {
        Task<List<PointDTO>> GetAllPoints(CancellationToken cancellationToken);
        Task<PointDTO> GetPointById(Guid id, CancellationToken cancellationToken);
        Task CreatePoint(CreatePointRequest request, CancellationToken cancellationToken);
        Task UpdatePoint(Guid id, UpdatePointRequest request, CancellationToken cancellationToken);
        Task DeletePoint(Guid id, CancellationToken cancellationToken);
    }
}
