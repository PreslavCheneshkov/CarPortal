using CarPortal.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPortal.Data.Entities.Car;
using static CarPortal.Data.Constants.OfferConstants;

namespace CarPortal.Data.Entities.Offer
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxOfferNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }

        [Required]
        public Car.Car Car { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CarPortalUser))]
        public string SellerId { get; set; } = null!;

        public CarPortalUser Seller { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [StringLength(AdditionalInfoMaxLength)]
        public string? AdditionalInfo { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEdited { get; set; }

        [ForeignKey(nameof(City))]
        [Required]
        public int CityId { get; set; }

        public City City { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Region))]
        public int RegionId { get; set; }

        public Region Region { get; set; } = null!;

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNumber { get; set; } = null!;

        [ForeignKey(nameof(OfferThumbnail))]
        public string? OfferThumbnailId { get; set; } = null!;

        public OfferThumbnail? OfferThumbnail { get; set; } = null!;

        public IEnumerable<CarImage> Images { get; set; } = new List<CarImage>();

        public IEnumerable<ProfileInterestedOffers> UsersInterested { get; set; } = new List<ProfileInterestedOffers>();

        public List<OfferComment> Comments { get; set; } = new List<OfferComment>();

        public bool IsActive { get; set; } = true;
    }
}
