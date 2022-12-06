using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class DropDownService : IDropDownService
    {
        private readonly CarPortalDbContext context;
        public DropDownService(CarPortalDbContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<VehicleModelDropDown>> GetModelsAsync(int manufacturerId)
        {
            var manufacturer = await context.Manufacturers
                                            .Include(m => m.Models)
                                            .Select(m => new
                                            {
                                                Id = m.Id,
                                                Models = m.Models.Select(x => new VehicleModelDropDown()
                                                {
                                                    Id = x.Id,
                                                    Name = x.Name,
                                                })
                                            })
                                            .FirstOrDefaultAsync(m => m.Id == manufacturerId);
            return manufacturer.Models;
        }

        public async Task<OfferDropDownsModel> PopulateViewModelWithDropDownsAsync()
        {
            var regions = await context.Regions.Select(r => new RegionDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var cities = await context.Cities.Select(r => new CityDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var colors = await context.Colors.Select(r => new ColorDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var fuelTypes = await context.FuelTypes.Select(r => new FuelTypeDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var manufacturers = await context.Manufacturers.Select(r => new ManufacturerDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var transmissionTypes = await context.TransmissionTypes.Select(r => new TransmissionTypeDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var vehicleCategories = await context.VehicleCategories.Select(r => new VehicleCategoryDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var vehicleModels = await context.Models.Select(r => new VehicleModelDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            OfferDropDownsModel model = new OfferDropDownsModel()
            {
                Cities = cities,
                Colors = colors,
                FuelTypes = fuelTypes,
                Manufacturers = manufacturers,
                TransmissionTypes = transmissionTypes,
                VehicleCategories = vehicleCategories,
                VehicleModels = vehicleModels,
                Regions = regions,
            };

            return model;
        }

        public async Task<List<SelectListItem>> PopulateVehicleExtrasCheckBoxesAsync()
        {
            return await context.Extras
                                   .Select(e => new SelectListItem()
                                   {
                                       Text = e.Name,
                                       Value = e.Id.ToString(),
                                       Selected = false,
                                   })
                                   .ToListAsync();
        }
    }
}
