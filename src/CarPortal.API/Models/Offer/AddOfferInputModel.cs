using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.OfferConstants;

namespace CarPortal.API.Models.Offer
{
    public class AddOfferInputModel
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

        [Required]
        public IFormFile Thumbnail { get; set; } = null!;

        public IEnumerable<IFormFile> Images { get; set; } = new List<IFormFile>();

        public AddCarInputModel Car { get; set; } = new AddCarInputModel();
    }
}
