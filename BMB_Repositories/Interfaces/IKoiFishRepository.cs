using BMB_Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_Repositories.Interfaces
{
    public interface IKoiFishRepository
    {
        Task<List<KoiFish>> GetAllAsync();
        Task<KoiFish> GetByIdAsync(int id);
        Task AddAsync(KoiFish koiFish);
        Task UpdateAsync(KoiFish koiFish);
        Task DeleteAsync(int id);

        Task<bool> AddImagesAsync(int koiFishId, List<string> imageUrls);
        Task<bool> RemoveImageAsync(int imageId, int koiFishId);

    }
}
