using NeonCinema_Application.DataTransferObject.Countrys;

namespace NeonCinema_Client.Data.IServices.Country
{
    public interface ICountryService
    {
        Task<List<CountryDTO>> GetAllCountries();
        Task<CountryDTO> GetCountryById(Guid id);
        Task<bool> CreateCountry(CountrysCreateRequest request);
        Task<bool> UpdateCountry(Guid id, CountryUpdateRequest request);
        Task<bool> DeleteCountry(Guid id);
    }
}
