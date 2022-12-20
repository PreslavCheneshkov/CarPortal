using CarPortal.Core.DTOs.Offer;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        Task<IEnumerable<OfferInCollectionDto>> GetRecentOffersAsync(int page);

        Task<SingleOfferDto> GetOfferByIdAsync(int offerId);

        Task AddCommentToOffer(string content, string authorUserId, int offerId);

        Task AddToInterestedIn(int offerId, string userId);
    }
}
