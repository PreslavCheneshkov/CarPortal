using CarPortal.Web.Attributes;
using CarPortal.Web.Models.Offer.DropDownModels;
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
        [Required]
        public int TransmissionTypeId { get; set; }
        [Required]
        [Year]
        public int Year { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public int ColorId { get; set; }

        public IEnumerable<VehicleCategoryDropDown> VehicleCategories { get; set; } = new List<VehicleCategoryDropDown>();
        public IEnumerable<VehicleModelDropDown> VehicleModels { get; set; } = new List<VehicleModelDropDown>();
        public IEnumerable<FuelTypeDropDown> FuelTypes { get; set; } = new List<FuelTypeDropDown>();
        public IEnumerable<TransmissionTypeDropDown> TransmissionTypes { get; set; } = new List<TransmissionTypeDropDown>();
        public IEnumerable<ColorDropDown> Colors { get; set; } = new List<ColorDropDown>();
        public IEnumerable<ManufacturerDropDown> Manufacturers { get; set; } = new List<ManufacturerDropDown>();
    }
}
