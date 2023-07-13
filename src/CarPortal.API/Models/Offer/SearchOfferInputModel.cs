using CarPortal.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CarPortal.API.Models.Offer
{
    public class SearchOfferInputModel
    {
        [Range(0, int.MaxValue)]
        public int? VehicleCategoryId { get; set; }

        [Range(0, int.MaxValue)]
        public int? ManufacturerId { get; set; }

        [Range(0, int.MaxValue)]
        public int? ModelId { get; set; }

        [Range(0, double.MaxValue)]
        public double? MinEngineDisplacement { get; set; }

        [Range(0, double.MaxValue)]
        public double? MaxEngineDisplacement { get; set; }

        [Range(0, int.MaxValue)]
        public int? MaxHorsePower { get; set; }

        [Range(0, int.MaxValue)]
        public int? MinHorsePower { get; set; }

        [Year]
        public int? MinYear { get; set; }

        [Year]
        public int? MaxYear { get; set; }

        [Range(0, int.MaxValue)]
        public int? MaxMileage { get; set; }

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal? MinPrice { get; set; }

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal? MaxPrice { get; set; }

        [StringLength(100)]
        public string? Keyword { get; set; }

        public bool? FromDealer { get; set; }

        public string? OrderBy { get; set; }

        public List<int> ExtraIds { get; set; } = new List<int>();

        public List<int> ColorIds { get; set; } = new List<int>();

        public List<int> FuelTypeIds { get; set; } = new List<int>();

        public List<int> TransmissionTypeIds { get; set; } = new List<int>();

        public List<int> RegionIds { get; set; } = new List<int>();
    }
}
