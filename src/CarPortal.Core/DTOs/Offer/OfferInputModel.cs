using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarPortal.Data.Constants.OfferConstants;

namespace CarPortal.Core.DTOs.Offer
{
    public class OfferInputModel
    {
        [Required]
        [StringLength(MaxOfferNameLength)]
        public string Name { get; set; } = null!;
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(AdditionalInfoMaxLength, MinimumLength = AdditionalInfoMinLength)]
        public string? AdditionalInfo { get; set; }

        [Required]
        public int RegionId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public string ContactPhoneNumber { get; set; } = null!;

        [Required]
        public IFormFile Thumbnail { get; set; } = null!;

        [Required]
        public IEnumerable<IFormFile> Images { get; set; } = new List<IFormFile>();


        public CarInputModel Car { get; set; } = new CarInputModel();
    }
}
