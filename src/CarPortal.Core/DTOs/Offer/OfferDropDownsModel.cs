using CarPortal.Core.DTOs.Offer.DropDownModels;
using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable

namespace CarPortal.Core.DTOs.Offer
{
    public class OfferDropDownsModel
    {
        public IEnumerable<CityDropDown> Cities { get; set; }
        
        public IEnumerable<ColorDropDown> Colors { get; set; }

        public IEnumerable<FuelTypeDropDown> FuelTypes { get; set; }

        public IEnumerable<ManufacturerDropDown> Manufacturers { get; set; }
        
        public IEnumerable<RegionDropDown> Regions { get; set; }
        
        public IEnumerable<TransmissionTypeDropDown> TransmissionTypes { get; set; }

        public IEnumerable<VehicleCategoryDropDown> VehicleCategories { get; set; }

        public IEnumerable<VehicleModelDropDown> VehicleModels { get; set; }

        public List<SelectListItem> Extras { get; set; }
    }
}
