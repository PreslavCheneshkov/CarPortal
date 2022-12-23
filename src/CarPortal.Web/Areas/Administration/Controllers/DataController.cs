using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.Car;
using CarPortal.Data.Entities.Offer;
using CarPortal.Web.Areas.Administration.Models;
using CarPortal.Web.Controllers;
using Ganss.Xss;
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
        private readonly HtmlSanitizer sanitizer;

        public DataController(
            CarPortalDbContext context,
            IPageDataService pageDataService)
        {
            this.context = context;
            this.pageDataService = pageDataService;
            sanitizer = new HtmlSanitizer();
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
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Add");
            }

            switch (dataType)
            {
                case "vehicleCategory":
                    if (model.NewCategory != null)
                    {
                        await this.pageDataService.AddData<VehicleCategory>(new VehicleCategory() { Name = this.sanitizer.Sanitize(model.NewCategory) });
                    }
                    break;
                case "manufacturer":
                    if (model.NewManufacturer != null)
                    {
                        await this.pageDataService.AddData<Manufacturer>(new Manufacturer() { Name = this.sanitizer.Sanitize(model.NewManufacturer) });
                    }
                    break;
                case "model":
                    if (model.NewModel != null && model.NewModelManufacturerId != null)
                    {
                        await this.pageDataService.AddData<Model>(new Model() { Name = this.sanitizer.Sanitize(model.NewModel), ManufacturerId = (int)model.NewModelManufacturerId });
                    }
                    break;
                case "transmissionType":
                    if (model.NewTransmissionType != null)
                    {
                        await this.pageDataService.AddData<TransmissionType>(new TransmissionType() { Name = this.sanitizer.Sanitize(model.NewTransmissionType) });
                    }
                    break;
                case "fuelType":
                    if (model.NewFuelType != null)
                    {
                        await this.pageDataService.AddData<FuelType>(new FuelType() { Name = this.sanitizer.Sanitize(model.NewFuelType) });
                    }
                    break;
                case "color":
                    if (model.NewColor != null)
                    {
                        await this.pageDataService.AddData<Color>(new Color() { Name = this.sanitizer.Sanitize(model.NewColor) });
                    }
                    break;
                case "extra":
                    if (model.NewExtra != null)
                    {
                        await this.pageDataService.AddData<Extra>(new Extra() { Name = this.sanitizer.Sanitize(model.NewExtra) });
                    }
                    break;
                case "region":
                    if (model.NewRegion!= null)
                    {
                        await this.pageDataService.AddData<Region>(new Region() { Name = this.sanitizer.Sanitize(model.NewRegion) });
                    }
                    break;
                case "city":
                    if (model.NewCityName != null && model.NewCityRegionId != null)
                    {
                        await this.pageDataService.AddData<City>(new City() { Name = this.sanitizer.Sanitize(model.NewCityName), RegionId = (int)model.NewCityRegionId });
                    }
                    break;
                default: return BadRequest();
            }

            return RedirectToAction("Current", "Data", new { area = "Administration" });
        }
    }
}
