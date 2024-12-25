using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.Interface.Countrys;
using NeonCinema_Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Countrys
{
    public class CountryRepository : ICountryRepository
    {
       private readonly NeonCinemasContext _context;
        public CountryRepository(NeonCinemasContext ct)
        {
            _context = ct;
        }
        public async Task<HttpResponseMessage> CreateRole(CountrysCreateRequest request, CancellationToken cancellationToken)
        {
            /// Kiểm tra không được để trống CountryName
            if (string.IsNullOrWhiteSpace(request.CountryName))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Country name is required.")
                };
            }
            var existingCountry = await _context.Country
                .FirstOrDefaultAsync(c => c.CountryName == request.CountryName, cancellationToken);

            if (existingCountry != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("Country with the same name already exists.")
                };
            }

            // Tạo mới country
            var newCountry = new NeonCinema_Domain.Database.Entities.Countrys
            {
                ID = request.ID != Guid.Empty ? request.ID : Guid.NewGuid(),
                CountryName = request.CountryName
            };

            // Thêm vào context và lưu thay đổi
            _context.Country.Add(newCountry);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Country created successfully.")
            };
        }

        public async Task<List<CountryDTO>> GetAllRole(CancellationToken cancellationToken)
        {
            var countries = await _context.Country
                .Select(c => new CountryDTO
                {
                    ID = c.ID,
                    CountryName = c.CountryName
                })
                .ToListAsync(cancellationToken);

            return countries;
        }

        public async Task<CountryDTO> GetByIDRole(Guid id, CancellationToken cancellationToken)
        {
            var country = await _context.Country
                .Where(c => c.ID == id)
                .Select(c => new CountryDTO
                {
                    ID = c.ID,
                    CountryName = c.CountryName
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (country == null)
            {
                throw new KeyNotFoundException("Country not found.");
            }

            return country;
        }

        public async Task<HttpResponseMessage> UpdateRole(Guid id, CountryUpdateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra xem country với ID đã cho có tồn tại hay không
            var existingCountry = await _context.Country
                .FirstOrDefaultAsync(c => c.ID == id, cancellationToken);

            if (existingCountry == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Country not found.")
                };
            }

            // Kiểm tra không được để trống CountryName
            if (string.IsNullOrWhiteSpace(request.CountryName))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Country name is required.")
                };
            }


            existingCountry.CountryName = request.CountryName;

            // Lưu thay đổi vào database
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Country updated successfully.")
            };
        }

    }
}
