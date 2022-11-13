using CarPortal.Core.DTOs.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface IOfferService
    {
        Task AddOfferAsync(OfferInputModel inputModel, string sellerId);

        Task<OfferDropDownsModel> PopulateViewModelWithDropDownsAsync();

        Task<IEnumerable<SeeAllOffersDto>> GetAllOffers();

        Task<SingleOfferDto> GetOfferByIdAsync(int offerId);
    }
}
