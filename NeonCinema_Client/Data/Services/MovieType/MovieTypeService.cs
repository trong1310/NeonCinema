using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Client.Data.IServices.IMovieType;

namespace NeonCinema_Client.Data.Services.MovieType
{
    public class MovieTypeService : IMovieTypeService
    {
        private readonly IMovieTypeRepositories _movieTypeService;
        public MovieTypeService(IMovieTypeRepositories movie)
        {
            _movieTypeService = movie;
        }
        public async Task<MovieTypeDTO> CreateMovieType(CreateMovieTypeRequest request, CancellationToken cancellationToken)
        {
            return await _movieTypeService.CreateMovieType(request, cancellationToken);
        }

        public async Task<List<MovieTypeDTO>> GetAllMovieType(CancellationToken cancellationToken)
        {
           return await _movieTypeService.GetAllMovieType(cancellationToken);
        }

        public async Task<MovieTypeDTO> GetMovieTypeById(Guid id, CancellationToken cancellationToken)
        {
            return await _movieTypeService.GetMovieTypeById(id, cancellationToken);
        }

        public async Task<HttpResponseMessage> UpdateMovieType(Guid id, UpdateMovieTypeRequest request, CancellationToken cancellationToken)
        {
            var MV = await _movieTypeService.UpdateMovieType(id, request, cancellationToken);
            return MV;
        }
    }
}
