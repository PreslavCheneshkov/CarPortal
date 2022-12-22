using CarPortal.Core.DTOs.Offer.DropDownModels;

namespace CarPortal.Web.Areas.Administration.Models
{
    public class DataViewModel
    {
        public List<string> VehicleCategories { get; set; } = new List<string>();

        public string? NewCategory { get; set; }

        public List<ManufacturerDropDown> Manufacturers { get; set; } = new List<ManufacturerDropDown>(); 

        public string? NewManufacturer { get; set; }

        public List<string> Models { get; set; } = new List<string>();

        public string? NewModel { get; set; }

        public int? NewModelManufacturerId { get; set; }

        public List<string> TransmissionTypes { get; set; } = new List<string>();

        public string? NewTransmissionType { get; set; }

        public List<string> FuelTypes { get; set; } = new List<string>();

        public string? NewFuelType { get; set; }

        public List<string> Extras { get; set; } = new List<string>();

        public string? NewExtra { get; set; }

        public List<string> Colors { get; set; } = new List<string>();

        public string? NewColor { get; set; }

        public List<RegionDropDown> RegionDropDowns { get; set; } = new List<RegionDropDown>();

        public string? NewRegion { get; set; }

        public List<string> Cities { get; set; } = new List<string>();

        public string? NewCityName { get; set; }

        public int? NewCityRegionId { get; set; }

        public string? AddedDataType { get; set; }
    }
}
