using BMB_Repositories.Data;
using BMB_Repositories.Entities;
using BMB_Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_Repositories.Implementations
{
    public class KoiFishRepository : IKoiFishRepository
    {
        private readonly AppDbContext _context;
        public KoiFishRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<KoiFish>> GetAllAsync() => await _context.KoiFishes.ToListAsync();

        public async Task<KoiFish?> GetByIdAsync(int id) => await _context.KoiFishes.FindAsync(id);

        public async Task AddAsync(KoiFish koi)
        {
            _context.KoiFishes.Add(koi);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(KoiFish koi)
        {
            _context.KoiFishes.Update(koi);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var koi = await _context.KoiFishes.FindAsync(id);
            if (koi != null)
            {
            _context.KoiFishes.Remove(koi);
            await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> AddImagesAsync(int koiFishId, List<string> imageUrls)
        {
            var koi = await _context.KoiFishes.FindAsync(koiFishId);
            if (koi == null || imageUrls == null || imageUrls.Count == 0)
                return false;

            var images = imageUrls.Select(url => new KoiFishImage
            {
                KoiFishId = koiFishId,
                ImageUrl = url
            });

            await _context.KoiFishImages.AddRangeAsync(images);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveImageAsync(int imageId, int koiFishId)
        {
            var image = await _context.KoiFishImages
                .FirstOrDefaultAsync(img => img.Id == imageId && img.KoiFishId == koiFishId);

            if (image == null)
                return false;

            _context.KoiFishImages.Remove(image);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
