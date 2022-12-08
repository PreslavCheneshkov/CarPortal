using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class SearchService : ISearchService
    {
        private readonly CarPortalDbContext context;

        public SearchService(CarPortalDbContext context)
        {
            this.context = context;
        }

        public Task<List<OfferInCollectionDto>> GetSearchResultsAsync(SearchModelDto inputModel)
        {
            IQueryable<OfferInCollectionDto> results;
            bool hasInfoFromDb = false;

            if (inputModel.ManufacturerId != null)
            {
                if (hasInfoFromDb)
                {
                    results = results.Where(x => x.Manufacturer)
                }
                else
                {

                }
            }

            throw new NotImplementedException();
        }
    }
}
