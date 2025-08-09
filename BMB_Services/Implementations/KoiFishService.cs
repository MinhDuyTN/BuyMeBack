using BMB_Repositories.Entities;
using BMB_Repositories.Interfaces;
using BMB_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_Services.Implementations
{
    public class KoiFishService : IKoiFishService
    {
        private readonly IKoiFishRepository _koiFishRepository;

        public KoiFishService(IKoiFishRepository koiFishRepository)
        {
            _koiFishRepository = koiFishRepository;
        }

        public async Task<IEnumerable<KoiFish>> GetAllAsync()
        {
            return await _koiFishRepository.GetAllAsync();
        }

        public async Task<KoiFish?> GetByIdAsync(int id)
        {
            return await _koiFishRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(KoiFish koiFish)
        {
            await _koiFishRepository.AddAsync(koiFish);
        }

        public async Task UpdateAsync(KoiFish koiFish)
        {
            await _koiFishRepository.UpdateAsync(koiFish);
        }

        public async Task DeleteAsync(int id)
        {
            await _koiFishRepository.DeleteAsync(id);
        }

        public async Task<bool> RemoveImageAsync(int imageId, int koiFishId)
        {
            return await _koiFishRepository.RemoveImageAsync(imageId, koiFishId);
        }

        public async Task<bool> AddImagesAsync(int koiFishId, List<string> imageUrls)
        {
            return await _koiFishRepository.AddImagesAsync(koiFishId, imageUrls);
        }
    }

}
