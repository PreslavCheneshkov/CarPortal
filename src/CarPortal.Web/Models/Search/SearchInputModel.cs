using CarPortal.Core.DTOs.Offer.DropDownModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarPortal.Web.Models.Search
{
    public class SearchInputModel
    {
        public int? VehicleCategoryID { get; set; }

        public int? ManufacturerId { get; set; }

        public int? ModelId { get; set; }

        public double? MinEngineDisplacement { get; set; }

        public double? MaxEngineDisplacement { get; set; }

        public int? MinYear { get; set; }

        public int? MaxYear { get; set; }

        public int? MinMileage { get; set; }

        public int? MaxMileage { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? MaxPrice { get; set; }

        public int? RegionId { get; set; }

        public int? CityId { get; set; }

        public List<SelectListItem> Extras { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> ColorIds { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> FuelTypesIds { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> TransmissionTypessIds { get; set; } = new List<SelectListItem>();

        //For dropdowns
        public IEnumerable<VehicleCategoryDropDown> VehicleCategories { get; set; } = new List<VehicleCategoryDropDown>();

        public IEnumerable<VehicleModelDropDown> VehicleModels { get; set; } = new List<VehicleModelDropDown>();

        public IEnumerable<FuelTypeDropDown> FuelTypes { get; set; } = new List<FuelTypeDropDown>();

        public IEnumerable<TransmissionTypeDropDown> TransmissionTypes { get; set; } = new List<TransmissionTypeDropDown>();

        public IEnumerable<ColorDropDown> Colors { get; set; } = new List<ColorDropDown>();

        public IEnumerable<ManufacturerDropDown> Manufacturers { get; set; } = new List<ManufacturerDropDown>();

        public IEnumerable<RegionDropDown> Regions { get; set; } = new List<RegionDropDown>();

        public IEnumerable<CityDropDown> Cities { get; set; } = new List<CityDropDown>();
    }
}
