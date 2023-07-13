using CarPortal.Core.DTOs.Offer.DropDownModels;

namespace CarPortal.Core.Services.Contracts
{
    public interface ICarDataService
    {
        Task<List<DropDownModel>> GetVehicleCategoriesAsync();

        Task<List<DropDownModel>> GetCarManufacturersAsync();

        Task<List<DropDownModel>> GetVehicleModelsAsync(int? manufacturerId);

        Task<List<DropDownModel>> GetCarFuelTypesAsync();

        Task<List<DropDownModel>> GetCarTransmissionsAsync();

        Task<List<DropDownModel>> GetColorsAsync();

        Task<List<DropDownModel>> GetVehicleExtrasAsync();
    }
}
