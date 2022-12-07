using CarPortal.Core.Attributes;
using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarPortal.Web.Models.Offer
{
    public class AddCarViewModel
    {
        [Required]
        public int VehicleCategoryId { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        public int ModelId { get; set; }

        [Required]
        public int FuelTypeId { get; set; }

        public double? EngineDisplacement { get; set; }

        public int? HorsePower { get; set; }

        [Required]
        public int TransmissionTypeId { get; set; }

        [Required]
        [Year]
        public int Year { get; set; }

        [Required]
        public int Mileage { get; set; }

        [Required]
        public int ColorId { get; set; }

        [Required]
        public bool IsBrandNew { get; set; }

        public IEnumerable<VehicleCategoryDropDown> VehicleCategories { get; set; } = new List<VehicleCategoryDropDown>();

        public IEnumerable<VehicleModelDropDown> VehicleModels { get; set; } = new List<VehicleModelDropDown>();

        public IEnumerable<FuelTypeDropDown> FuelTypes { get; set; } = new List<FuelTypeDropDown>();

        public IEnumerable<TransmissionTypeDropDown> TransmissionTypes { get; set; } = new List<TransmissionTypeDropDown>();

        public IEnumerable<ColorDropDown> Colors { get; set; } = new List<ColorDropDown>();

        public IEnumerable<ManufacturerDropDown> Manufacturers { get; set; } = new List<ManufacturerDropDown>();

        public List<SelectListItem> Extras { get; set; } = new List<SelectListItem>();

        //public List<string> ExtraId { get; set; } = new List<string>();
    }
}
