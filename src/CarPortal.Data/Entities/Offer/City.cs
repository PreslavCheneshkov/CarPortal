using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Offer
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Region))]
        public int RegionId { get; set; }
        public Region Region { get; set; } = null!;

        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}
