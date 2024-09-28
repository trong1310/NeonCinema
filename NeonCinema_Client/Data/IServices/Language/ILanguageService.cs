using NeonCinema_Application.DataTransferObject.Language;

namespace NeonCinema_Client.Data.IServices.Language
{
    public interface ILanguageService
    {
        Task<List<LanguageDTO>> GetAllLanguages();
        Task<LanguageDTO> GetLanguageById(Guid id);
        Task CreateLanguage(CreateLanguageRequest request);
        Task UpdateLanguage(Guid id, UpdateLanguageRequest request);
        Task DeleteLanguage(Guid id);
    }
}
