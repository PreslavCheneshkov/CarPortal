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
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
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
        public int? CityId { get; set; }
        public City City { get; set; } = null!;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNumber { get; set; } = null!;
    }
}
