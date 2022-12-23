using CarPortal.Core.DTOs.Offer;

namespace CarPortal.Core.Services.Contracts
{
    public interface IOfferService
    {
        Task AddOfferAsync(OfferInputModel inputModel, string sellerId);

        Task<IEnumerable<OfferInCollectionDto>> GetRecentOffersAsync();

        Task<SingleOfferDto> GetOfferByIdAsync(int offerId);

        Task AddCommentToOffer(string content, string authorUserId, int offerId);

        Task Delete(int offerId);
    }
}
