using CarPortal.Core.DTOs.Offer.DropDownModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.Search
{
    public class SearchInputModel
    {
        public List<SelectListItem> Extras { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Colors { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> FuelTypes { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> TransmissionTypes { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Regions { get; set; } = new List<SelectListItem>();

        //For dropdowns
        public IEnumerable<VehicleCategoryDropDown> VehicleCategories { get; set; } = new List<VehicleCategoryDropDown>();

        public IEnumerable<VehicleModelDropDown> VehicleModels { get; set; } = new List<VehicleModelDropDown>();

        public IEnumerable<ManufacturerDropDown> Manufacturers { get; set; } = new List<ManufacturerDropDown>();
    }
}
