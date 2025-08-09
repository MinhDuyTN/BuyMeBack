using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_Repositories.Entities
{
    [Table("KoiFishImage")]
    public class KoiFishImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        // Foreign key
        public int KoiFishId { get; set; }

        public virtual KoiFish KoiFish { get; set; } = null!;
    }

}
