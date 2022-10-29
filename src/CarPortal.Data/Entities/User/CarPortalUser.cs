using Microsoft.AspNetCore.Identity;
using CarPortal.Data.Entities.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.User
{
    public class CarPortalUser : IdentityUser
    {
        public string? ProfilePictureAddress { get; set; }
        public ICollection<Offer.Offer>? PublishedOffers { get; set; }
        public ICollection<Offer.Offer>? SavedOffers { get; set; }

    }
}
