using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Offer
{
    public class OfferThumbnail
    {
        public OfferThumbnail()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }


        [ForeignKey(nameof(Offer))]
        public int? OfferId { get; set; }

        public virtual Offer Offer { get; set; } = null!;

        [Required]
        public string Extension { get; set; } = null!;
    }
}
