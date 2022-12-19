using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface ISearchService
    {
        Task<List<OfferInCollectionDto>> GetOfferSearchResultsAsync(SearchModelDto inputModel);

        Task<List<string>> GetDealerSearchResultsAsync(string username);
    }
}
