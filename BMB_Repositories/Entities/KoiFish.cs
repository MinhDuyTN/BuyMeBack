using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_Repositories.Entities
{
    [Table("KoiFish")]
    public class KoiFish
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Variety { get; set; } = null!;     // giống cá Koi (VD: Kohaku, Sanke, Showa, v.v.)
        public string Color { get; set; } = null!;
        public double LengthCm { get; set; }            
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }             
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public virtual ICollection<KoiFishImage> Images { get; set; } = new List<KoiFishImage>();
    }
}
