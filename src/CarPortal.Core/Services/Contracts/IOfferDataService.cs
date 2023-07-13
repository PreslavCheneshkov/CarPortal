using CarPortal.Core.DTOs.Offer.DropDownModels;

namespace CarPortal.Core.Services.Contracts
{
    public interface IOfferDataService
    {
        Task<List<DropDownModel>> GetRegionsAsync();

        Task<List<DropDownModel>> GetCitiesAsync(int? regionId);

        Task<AddOfferInitialDropDowns> GetDropDownsForAddingOfferAsync();
    }
}
