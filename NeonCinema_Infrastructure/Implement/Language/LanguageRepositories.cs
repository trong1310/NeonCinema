using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.Interface.Language;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Languages
{
    public class LanguageRepositories : ILanguageRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public LanguageRepositories(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Lấy tất cả ngôn ngữ
        public async Task<List<LanguageDTO>> GetAllLanguages(CancellationToken cancellationToken)
        {
            var languages = await _context.Lenguages.ToListAsync(cancellationToken);
            return _mapper.Map<List<LanguageDTO>>(languages);
        }

        // Lấy ngôn ngữ theo ID
        public async Task<LanguageDTO> GetLanguageById(Guid id, CancellationToken cancellationToken)
        {
            var language = await _context.Lenguages.FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
            if (language == null) return null;
            return _mapper.Map<LanguageDTO>(language);
        }

        // Tạo ngôn ngữ mới
        public async Task CreateLanguage(CreateLanguageRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var language = _mapper.Map<Language>(request);
                _context.Lenguages.Add(language);
                await _context.SaveChangesAsync(cancellationToken);

                Console.WriteLine("Ngôn ngữ được tạo thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tạo ngôn ngữ: {ex.Message}");
                throw;
            }
        }

        // Cập nhật thông tin ngôn ngữ
        public async Task UpdateLanguage(Guid id, UpdateLanguageRequest request, CancellationToken cancellationToken)
        {
            var language = await _context.Lenguages.FindAsync(id);
            if (language == null)
            {
                Console.WriteLine("Ngôn ngữ không tồn tại!");
                return;
            }

            _mapper.Map(request, language);
            _context.Lenguages.Update(language);
            await _context.SaveChangesAsync(cancellationToken);

            Console.WriteLine("Ngôn ngữ được cập nhật thành công!");
        }

        // Xóa ngôn ngữ theo ID
        public async Task DeleteLanguage(Guid id, CancellationToken cancellationToken)
        {
            var language = await _context.Lenguages.FindAsync(id);
            if (language == null)
            {
                Console.WriteLine("Ngôn ngữ không tồn tại!");
                return;
            }

            _context.Lenguages.Remove(language);
            await _context.SaveChangesAsync(cancellationToken);

            Console.WriteLine("Ngôn ngữ đã được xóa thành công!");
        }
    }
}
