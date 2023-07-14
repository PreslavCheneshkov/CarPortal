using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.Core.Services
{
    public class CarDataService : ICarDataService
    {
        private readonly CarPortalDbContext _dbContext;

        public CarDataService(CarPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DropDownModel>> GetCarFuelTypesAsync()
            => await _dbContext.FuelTypes.Select(f => new DropDownModel
            {
                Id = f.Id,
                Name = f.Name,
            }).ToListAsync();

        public async Task<List<DropDownModel>> GetCarManufacturersAsync()
            => await _dbContext.Manufacturers.Select(m => new DropDownModel
            {
                Id = m.Id,
                Name = m.Name,
            }).ToListAsync();

        public async Task<List<DropDownModel>> GetCarTransmissionsAsync()
            => await _dbContext.TransmissionTypes.Select(t => new DropDownModel
            {
                Id = t.Id,
                Name = t.Name,
            }).ToListAsync();

        public async Task<List<DropDownModel>> GetColorsAsync()
            => await _dbContext.Colors.Select(c => new DropDownModel
            {
                Id = c.Id,
                Name = c.Name,
            }).ToListAsync();

        public async Task<List<DropDownModel>> GetVehicleCategoriesAsync()
            => await _dbContext.VehicleCategories.Select(vc => new DropDownModel
            {
                Id = vc.Id,
                Name = vc.Name,
            }).ToListAsync();

        public async Task<List<DropDownModel>> GetVehicleExtrasAsync()
            => await _dbContext.Extras.Select(e => new DropDownModel
            {
                Id = e.Id,
                Name = e.Name,
            }).ToListAsync();

        public async Task<List<DropDownModel>> GetVehicleModelsAsync(int? manufacturerId)
        {
            var models = _dbContext.Models.AsQueryable();
            if (manufacturerId != null)
                models = models.Where(m => m.ManufacturerId == manufacturerId);

            return await models.Select(m => new DropDownModel
            {
                Id = m.Id,
                Name = m.Name,
            }).ToListAsync();
        }
    }
}
