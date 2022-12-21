using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable

namespace CarPortal.Core.DTOs.Offer
{
    public class SingleOfferDto
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public CarInSingleOfferDto CarDto { get; set; }

        public decimal Price { get; set; }

        public string SellerId { get; set; }

        public string SellerName { get; set; }

        public DateTime LastEdited { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ThumbnailUrl { get; set; }

        public IEnumerable<string> PictureIds { get; set; } = new List<string>();

        public string AdditionalInfo { get; set; }

        public List<OfferCommentDTO> Comments { get; set; }

        public bool IsActive { get; set; }
    }
}
