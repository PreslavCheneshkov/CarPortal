using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.Core.Services
{
    public class PageDataService : IPageDataService
    {
        private readonly CarPortalDbContext context;
        public PageDataService(CarPortalDbContext _context)
        {
            context = _context;
        }
        public async Task<List<VehicleModelDropDown>> GetModelsAsync(int manufacturerId)
        {
            var models = await this.context.Models
                                    .Where(m => m.ManufacturerId == manufacturerId)
                                    .Select(m => new VehicleModelDropDown()
                                    {
                                        Id = m.Id,
                                        Name = m.Name,
                                        ManufacturerId = m.ManufacturerId,
                                    })
                                    .OrderBy(m => m.Name)
                                    .ToListAsync();

            return models;
        }

        private async Task<IEnumerable<RegionDropDown>> GetRegionsDropDownsAsync()
        {
            return await context.Regions
                                .Select(r => new RegionDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                })
                                .ToArrayAsync();
        }

        private async Task<IEnumerable<CityDropDown>> GetCityDropDownsAsync()
        {
            return await context.Cities
                                .Select(r => new CityDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                }).ToArrayAsync();
        }

        private async Task<IEnumerable<ManufacturerDropDown>> GetManufacturerDropDownsAsync()
        {
            return await context.Manufacturers
                                .Select(r => new ManufacturerDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                })
                                .ToArrayAsync();
        }

        private async Task<IEnumerable<VehicleModelDropDown>> GetVehicleModelDropDownsAsync()
        {
            return await context.Models
                                .Select(r => new VehicleModelDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                }).ToArrayAsync();
        }

        private async Task<IEnumerable<VehicleCategoryDropDown>> GetVehicleCategoryDropDownsAsync()
        {
            return await context.VehicleCategories
                                .Select(r => new VehicleCategoryDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                }).ToArrayAsync();
        }

        private async Task<IEnumerable<FuelTypeDropDown>> GetFuelTypeDropDownsAsync()
        {
            return await context.FuelTypes
                                .Select(r => new FuelTypeDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                }).ToArrayAsync();
        }

        private async Task<IEnumerable<TransmissionTypeDropDown>> GetTransmissionTypeDropDownsAsync()
        {
            return await context.TransmissionTypes
                                .Select(r => new TransmissionTypeDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                }).ToArrayAsync();
        }

        private async Task<IEnumerable<ColorDropDown>> GetColorDropDownsAsync()
        {
            return await context.Colors
                                .Select(r => new ColorDropDown
                                {
                                    Name = r.Name,
                                    Id = r.Id,
                                }).ToArrayAsync();
        }

        public async Task<OfferDropDownsModel> PopulateViewModelWithDropDownsAsync()
        {
            var vehicleCategories = await this.GetVehicleCategoryDropDownsAsync();

            var manufacturers = await this.GetManufacturerDropDownsAsync();
            var vehicleModels = await this.GetVehicleModelDropDownsAsync();

            var regions = await this.GetRegionsDropDownsAsync();
            var cities = await this.GetCityDropDownsAsync();

            var fuelTypes = await this.GetFuelTypeDropDownsAsync();
            var transmissionTypes = await this.GetTransmissionTypeDropDownsAsync();

            var colors = await this.GetColorDropDownsAsync();

            var extras = await this.PopulateVehicleExtrasCheckboxesAsync();

            OfferDropDownsModel model = new OfferDropDownsModel()
            {
                // TODO : Most of these should be handled by ajax after user input.
                Cities = cities,
                Colors = colors,
                FuelTypes = fuelTypes,
                Manufacturers = manufacturers.OrderBy(x => x.Name).ToList(),
                TransmissionTypes = transmissionTypes,
                VehicleCategories = vehicleCategories,
                VehicleModels = vehicleModels,
                Regions = regions,
                Extras = extras,
            };

            return model;
        }

        private async Task<List<SelectListItem>> PopulateVehicleExtrasCheckboxesAsync()
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

        private async Task<List<SelectListItem>> PopulateColorCheckboxesAsync()
        {
            return await context.Colors
                                .Select(c => new SelectListItem()
                                {
                                    Text = c.Name,
                                    Value = c.Id.ToString(),
                                    Selected = false,
                                })
                                .ToListAsync();
        }

        private async Task<List<SelectListItem>> PopulateFuelTypeCheckboxesAsync()
        {
            return await context.FuelTypes
                                .Select(f => new SelectListItem()
                                {
                                    Text = f.Name,
                                    Value = f.Id.ToString(),
                                    Selected = false,
                                })
                                .ToListAsync();
        }

        private async Task<List<SelectListItem>> PopulateRegionCheckboxesAsync()
        {
            return await context.Regions
                                .Select(r => new SelectListItem()
                                {
                                    Text = r.Name,
                                    Value = r.Id.ToString(),
                                    Selected = false,
                                })
                                .ToListAsync();
        }

        private async Task<List<SelectListItem>> PopulateTransmissionTypeCheckboxesAsync()
        {
            return await context.TransmissionTypes
                                .Select(t => new SelectListItem()
                                {
                                    Text = t.Name,
                                    Value = t.Id.ToString(),
                                    Selected = false,
                                })
                                .ToListAsync();
        }

        private async Task<SearchCheckBoxesModel> PopulateSearchModelCheckboxesAsync()
        {
            SearchCheckBoxesModel checkboxes = new SearchCheckBoxesModel()
            {
                Extras = await this.PopulateVehicleExtrasCheckboxesAsync(),
                Colors = await this.PopulateColorCheckboxesAsync(),
                FuelTypes = await this.PopulateFuelTypeCheckboxesAsync(),
                TransmissionTypes = await this.PopulateTransmissionTypeCheckboxesAsync(),
                Regions = await this.PopulateRegionCheckboxesAsync(),
            };

            return checkboxes;
        }

        public async Task<SearchInputModel> PopulateSearchModelAsync()
        {
            var checkboxes = await this.PopulateSearchModelCheckboxesAsync();

            //dropdowns
            var vehicleCategories = await this.GetVehicleCategoryDropDownsAsync();
            var manufacturers = await this.GetManufacturerDropDownsAsync();
            //var vehicleModels = await this.GetVehicleModelDropDownsAsync();

            var model = new SearchInputModel()
            {
                //dropdowns
                VehicleCategories = vehicleCategories,
                Manufacturers = manufacturers,
                //VehicleModels = vehicleModels,
                //checkboxes
                Extras = checkboxes.Extras,
                Colors = checkboxes.Colors,
                FuelTypes = checkboxes.FuelTypes,
                TransmissionTypes = checkboxes.TransmissionTypes,
                Regions = checkboxes.Regions,
            };

            return model;
        }

        public async Task<List<CityDropDown>> GetCitiesAsync(int regionId)
        {
            var cities = await this.context.Cities
                                    .Where(c => c.RegionId == regionId)
                                    .Select(c => new CityDropDown()
                                    {
                                        Id = c.Id,
                                        Name = c.Name,
                                    })
                                    .OrderBy(c => c.Name)
                                    .ToListAsync();

            return cities;
        }

        public async Task AddData<T>(T item) where T : class
        {
            await context.AddAsync<T>(item);
            await context.SaveChangesAsync();
        }
    }
}
