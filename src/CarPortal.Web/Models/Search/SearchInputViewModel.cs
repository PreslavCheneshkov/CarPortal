using CarPortal.Core.Attributes;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarPortal.Web.Models.Search
{
    public class SearchInputViewModel// : IValidatableObject
    {
        [Range(0, int.MaxValue)]
        public int? VehicleCategoryId { get; set; }

        [Range(0, int.MaxValue)]
        public int? ManufacturerId { get; set; }

        [Range(0, int.MaxValue)]
        public int? ModelId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        public double? MinEngineDisplacement { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        public double? MaxEngineDisplacement { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive whole numer.")]
        public int? MaxHorsePower { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive whole numer.")]
        public int? MinHorsePower { get; set; }

        [Year]
        public int? MinYear { get; set; }

        [Year]
        public int? MaxYear { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a positive whole numer.")]
        public int? MaxMileage { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        [DataType(DataType.Currency)]
        public decimal? MinPrice { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        [DataType(DataType.Currency)]
        public decimal? MaxPrice { get; set; }

        [StringLength(100)]
        public string? Keyword { get; set; }

        public bool? FromDealer { get; set; }

        public string? OrderBy { get; set; }

        public List<SelectListItem> Extras { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Colors { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> FuelTypes { get; set; } = new List<SelectListItem>();
        
        public List<SelectListItem> TransmissionTypes { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Regions { get; set; } = new List<SelectListItem>();

        //For dropdowns
        public IEnumerable<VehicleCategoryDropDown>? VehicleCategories { get; set; } = new List<VehicleCategoryDropDown>();

        public IEnumerable<VehicleModelDropDown>? VehicleModels { get; set; } = new List<VehicleModelDropDown>();

        public IEnumerable<ManufacturerDropDown>? Manufacturers { get; set; } = new List<ManufacturerDropDown>();

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    //TODO higher end values should be higher than lower end
        //    throw new NotImplementedException();
        //}
    }
}
