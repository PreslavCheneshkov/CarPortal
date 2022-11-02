using CarPortal.Web.Models.Offer.DropDownModels;
using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.OfferConstants;

namespace CarPortal.Web.Models.Offer
{
    public class AddOfferViewModel
    {
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        [StringLength(AdditionalInfoMaxLength, MinimumLength = AdditionalInfoMinLength)]
        public string? AdditionalInfo { get; set; }
        [Required]
        public int CityId { get; set; }
        public IEnumerable<RegionDropDown> Regions { get; set; } = new List<RegionDropDown>();
        public IEnumerable<CityDropDown> Cities { get; set; } = new List<CityDropDown>();
        public AddCarViewModel Car { get; set; } = new AddCarViewModel();
    }
}
