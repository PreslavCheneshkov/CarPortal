using CarPortal.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarPortal.Data.Constants.OfferConstants;

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
        [ForeignKey(nameof(CarPortalProfile))]
        public string CarPortalProfileId { get; set; }

        public CarPortalProfile CarPortalProfile { get; set; } = null!;

        [Required]
        [StringLength(OfferCommentMaxLength, MinimumLength = OfferCommentMinLength, ErrorMessage = "Comment length should be between 2 and 200 characters.")]
        public string Content { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
