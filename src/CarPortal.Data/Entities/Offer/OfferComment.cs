using CarPortal.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Offer
{
    public class OfferComment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Offer))]
        public int OfferId { get; set; }
        public Offer Offer { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(CarPortalUser))]
        public int CarPortalUserId { get; set; }
        public CarPortalUser Author { get; set; } = null!;
        [Required]
        [StringLength(300)]
        public string Content { get; set; } = null!;
        public ICollection<OfferComment> Replies { get; set; } = new List<OfferComment>();
    }
}
