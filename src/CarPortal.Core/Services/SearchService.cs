using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class SearchService : ISearchService
    {
        public Task<OfferInCollectionDto> GetSearchResultsAsync(SearchInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
