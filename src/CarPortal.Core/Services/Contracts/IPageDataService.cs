using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.DTOs.Search;

namespace CarPortal.Core.Services.Contracts
{
    public interface IPageDataService
    {
        Task<List<VehicleModelDropDown>> GetModelsAsync(int manufacturerId);

        Task<OfferDropDownsModel> PopulateViewModelWithDropDownsAsync();

        Task<SearchInputModel> PopulateSearchModelAsync();

        Task<List<CityDropDown>> GetCitiesAsync(int regionId);

        Task AddData<T>(T item) where T : class;
    }
}
