using Azure.Core;
using Com.CloudRail.SI.ServiceCode.Commands;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Client.Data.IServices.Director;
using NeonCinema_Domain.Database.Entities;
using System.Net;

namespace NeonCinema_Client.Data.Services.Director
{
    public class DirectorService : IDirectorService
    {

        private readonly IDirectorRepositories _DRTRepository;

        public DirectorService(IDirectorRepositories DRTRepository)
        {
            _DRTRepository = DRTRepository;
        }

        public async Task<DirectorDTO> CreateDirector(CreateDirectorRequest request, CancellationToken cancellationToken)
        {
            return await _DRTRepository.CreateDirector(request, cancellationToken);
        }

        public async Task<List<DirectorDTO>> GetAllDirector(CancellationToken cancellationToken)
        {
            var actors = await _DRTRepository.GetAllDirector(cancellationToken);
            return actors; // Trả về danh sách ActorDTO
        }

        public async Task<DirectorDTO> GetDirectorById(Guid id, CancellationToken cancellationToken)
        {
            var drt = await _DRTRepository.GetDirectorById(id, cancellationToken);
            if (drt == null)
            {
                
                throw new KeyNotFoundException($"director with ID {id} not found.");
            }

            return drt;
        }

        public async Task<HttpResponseMessage> UpdateDirector(Guid id, UpdateDirectorRequest request, CancellationToken cancellationToken)
        {
            var response = await _DRTRepository.UpdateDirector(id, request, cancellationToken);

            // Kiểm tra mã trạng thái phản hồi
            if (!response.IsSuccessStatusCode)
            {
                // Nếu không thành công, có thể ném ra ngoại lệ hoặc xử lý tùy ý
                throw new HttpRequestException($"Error updating director: {response.ReasonPhrase}");
            }

            return response;
        }
    }   
}
