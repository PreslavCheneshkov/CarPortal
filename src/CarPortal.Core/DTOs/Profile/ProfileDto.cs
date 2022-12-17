using CarPortal.Core.DTOs.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.Profile
{
    public class ProfileDto
    {
        public string ProfileId { get; set; }

        public string UserName { get; set; }

        public bool IsDealer { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ProfilePictureAddress { get; set; }

        public string UserId { get; set; }

        public List<OfferInCollectionDto> UploadedOffers { get; set; }

        public List<OfferInCollectionDto> SavedOffers { get; set; }
    }
}
