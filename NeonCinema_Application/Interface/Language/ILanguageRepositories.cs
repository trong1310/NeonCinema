using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.DataTransferObject.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Language
{
    public interface ILanguageRepositories
    {
        Task<List<LanguageDTO>> GetAllLanguages(CancellationToken cancellationToken);
        Task<LanguageDTO> GetLanguageById(Guid id, CancellationToken cancellationToken);
        Task CreateLanguage(CreateLanguageRequest request, CancellationToken cancellationToken);
        Task UpdateLanguage(Guid id, UpdateLanguageRequest request, CancellationToken cancellationToken);
        Task DeleteLanguage(Guid id, CancellationToken cancellationToken);
    }
}
