using CarPortal.Core.DTOs.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface INewsService
    {
        Task CreateArticleAsync(NewsArticleInputDTO inputModel, string authorId);

        Task<List<NewsArticleInCollectionDTO>> GetMostRecentArticles();

        Task<NewsArticleDetailsDTO> GetNewsArticleDetailsAsync(int id);

        Task AddCommentToNewsArticle(string content, string authorUserId, int newsArticleId);
    }
}
