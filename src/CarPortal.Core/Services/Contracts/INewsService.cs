using CarPortal.Core.DTOs.News;

namespace CarPortal.Core.Services.Contracts
{
    public interface INewsService
    {
        Task CreateArticleAsync(NewsArticleInputDTO inputModel, string authorId);

        Task<List<NewsArticleInCollectionDTO>> GetMostRecentArticles();

        Task<NewsArticleDetailsDTO> GetNewsArticleDetailsAsync(int id);

        Task EditArticleAsync(NewsArticleInputDTO article, int id);
    }
}
