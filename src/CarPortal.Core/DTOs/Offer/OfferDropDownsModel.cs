using CarPortal.Core.Dtos.Offer.DropDownModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
