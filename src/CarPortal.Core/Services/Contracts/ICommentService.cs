using CarPortal.Core.DTOs.News;
using CarPortal.Core.DTOs.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface ICommentService
    {
        Task<IEnumerable<OfferCommentDTO>> GetOfferComments(int offerId);

        Task<IEnumerable<NewsArticleCommentDTO>> GetNewsArticleComments(int newsArticleId);

        Task AddCommentToNewsArticle(string content, string authorUserId, int newsArticleId);

        Task AddCommentToOffer(string content, string authorUserId, int offerId);

    }
}
