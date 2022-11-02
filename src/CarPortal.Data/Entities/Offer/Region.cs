using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Offer
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public ICollection<City> Cities { get; set; } = new List<City>();
        public ICollection<Offer> Offers { get; set; } = new List<Offer>();

    }
}
