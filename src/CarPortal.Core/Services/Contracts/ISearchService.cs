using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Search;

namespace CarPortal.Core.Services.Contracts
{
    public interface ISearchService
    {
        Task<List<OfferInCollectionDto>> GetOfferSearchResultsAsync(SearchModelDto inputModel);

        Task<List<DealerSearchResultDTO>> GetDealerSearchResultsAsync(string username);

        Task<List<NewsArticleSearchResultDTO>> GetNewsArticlesSearchResultsAsync(string keyword);
    }
}
