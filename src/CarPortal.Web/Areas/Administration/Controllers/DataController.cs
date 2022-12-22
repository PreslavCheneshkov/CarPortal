using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Web.Areas.Administration.Models;
using CarPortal.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CarPortal.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Administration")]
    public class DataController : CarPortalController
    {
        private readonly CarPortalDbContext context;
        private readonly IPageDataService pageDataService;

        public DataController(
            CarPortalDbContext context,
            IPageDataService pageDataService)
        {
            this.context = context;
            this.pageDataService = pageDataService;
        }

        [HttpGet]
        public async Task<IActionResult> Current()
        {
            var data = await this.pageDataService.PopulateViewModelWithDropDownsAsync();

            DataViewModel model = new DataViewModel()
            {
                Cities = data.Cities.Select(c => c.Name).ToList(),
                Colors = data.Colors.Select(x => x.Name).ToList(),
                Extras = data.Extras.Select(x => x.Text).ToList(),
                FuelTypes = data.FuelTypes.Select(x => x.Name).ToList(),
                Models = data.VehicleModels.Select(x => x.Name).ToList(),
                TransmissionTypes = data.TransmissionTypes.Select(x => x.Name).ToList(),
                VehicleCategories = data.VehicleCategories.Select(x => x.Name).ToList(),
                RegionDropDowns = data.Regions.Select(x => new RegionDropDown()
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList(),
                Manufacturers = data.Manufacturers.Select(x => new ManufacturerDropDown()
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DataViewModel model, string dataType)
        {
            switch (dataType)
            {
                case "vehicleCategory": break;
                case "maunfacturer": break;
                default:
                    break;
            }

            return RedirectToAction("Current", "Data", new { area = "Administration" });
        }
    }
}
