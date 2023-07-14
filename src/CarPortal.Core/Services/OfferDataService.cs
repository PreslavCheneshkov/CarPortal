using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.Core.Services
{
    public class OfferDataService : IOfferDataService
    {
        private readonly CarPortalDbContext _dbContext;
        private readonly ICarDataService _carDataService;

        public OfferDataService(CarPortalDbContext dbContext, ICarDataService carDataService)
        {
            _dbContext = dbContext;
            _carDataService = carDataService;
        }

        public async Task<List<DropDownModel>> GetCitiesAsync(int? regionId)
        {
            var cities = _dbContext.Cities.AsQueryable();
            if (regionId != null)
                cities = cities.Where(c => c.RegionId == regionId);

            return await cities.Select(c => new DropDownModel
            {
                Id = c.Id,
                Name = c.Name,
            }).ToListAsync();
        }

        public async Task<List<DropDownModel>> GetRegionsAsync()
            => await _dbContext.Regions.Select(r => new DropDownModel
            {
                Id = r.Id,
                Name = r.Name,
            }).ToListAsync();

        public async Task<AddOfferInitialDropDowns> GetDropDownsForAddingOfferAsync()
            => new AddOfferInitialDropDowns
            {
                Colors = await _carDataService.GetColorsAsync(),
                Extras = await _carDataService.GetVehicleExtrasAsync(),
                FuelTypes = await _carDataService.GetCarFuelTypesAsync(),
                Manufacturers = await _carDataService.GetCarManufacturersAsync(),
                Regions = await this.GetRegionsAsync(),
                TransmissionTypes = await _carDataService.GetCarTransmissionsAsync(),
                VehicleCategories = await _carDataService.GetVehicleCategoriesAsync(),
            };

    }
}
