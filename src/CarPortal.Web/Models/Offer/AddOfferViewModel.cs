using CarPortal.Core.DTOs.Offer.DropDownModels;
using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.OfferConstants;

namespace CarPortal.Web.Models.Offer
{
    public class AddOfferViewModel
    {
        [Required]
        [StringLength(MaxOfferNameLength, MinimumLength = MinOfferNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(AdditionalInfoMaxLength, MinimumLength = AdditionalInfoMinLength)]
        public string? AdditionalInfo { get; set; }

        [Required]
        public int RegionId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public string ContactPhoneNumber { get; set; } = null!;

        public IEnumerable<RegionDropDown> Regions { get; set; } = new List<RegionDropDown>();

        public IEnumerable<CityDropDown> Cities { get; set; } = new List<CityDropDown>();

        [Required]
        public IFormFile Thumbnail { get; set; } = null!;

        public IEnumerable<IFormFile> Images { get; set; } = new List<IFormFile>();

        public AddCarViewModel Car { get; set; } = new AddCarViewModel();
    }
}
