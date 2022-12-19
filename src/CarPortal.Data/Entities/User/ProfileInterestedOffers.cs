using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.User
{
    public class ProfileInterestedOffers
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(CarPortalProfile))]
        public string CarPortalProfileId { get; set; } = null!;

        public CarPortalProfile Profile { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Entities.Offer.Offer))]
        public int OfferId { get; set; }

        public Offer.Offer Offer { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;
    }
}
