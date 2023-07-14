using CarPortal.Core.DTOs.News;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.News;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly CarPortalDbContext context;

        public NewsService(CarPortalDbContext context)
        {
            this.context = context;
        }

        public async Task CreateArticleAsync(NewsArticleInputDTO inputModel, string authorId)
        {
            string profileId = await context.Users
                                            .Where(u => u.Id == authorId)
                                            .Select(u => u.ProfileId)
                                            .FirstOrDefaultAsync();

            if (profileId == null)
            {
                throw new ArgumentNullException();
            }

            NewsArticle article = new NewsArticle()
            {
                AuthorId = profileId,
                Title = inputModel.Title,
                Content = inputModel.Content,
            };

            await this.context.AddAsync(article);
            await this.context.SaveChangesAsync();
        }

        public async Task EditArticleAsync(NewsArticleInputDTO input, int id)
        {
            var article = await context.NewsArticles.FirstOrDefaultAsync(a => a.Id == id);

            if (article == null) 
            {
                throw new ArgumentNullException();
            }

            article.Title = input.Title;
            article.Content = input.Content;

            await this.context.SaveChangesAsync();
        }

        public async Task<List<NewsArticleInCollectionDTO>> GetMostRecentArticles()
        {
            return await this.context.NewsArticles
                                            .OrderByDescending(a => a.CreatedOn)
                                            .Select(a => new NewsArticleInCollectionDTO()
                                            {
                                                Author = a.Author.CarPortalUser.UserName,
                                                Title = a.Title,
                                                Content = a.Content,
                                                CreatedOn = a.CreatedOn.ToShortDateString(),
                                                Id = a.Id,
                                            })
                                            .Take(5)
                                            .ToListAsync();
        }

        public async Task<NewsArticleDetailsDTO> GetNewsArticleDetailsAsync(int id)
        {
            return await context.NewsArticles
                                            .Where(a => a.Id == id)
                                            .Select(a => new NewsArticleDetailsDTO()
                                            {
                                                Author = a.Author.CarPortalUser.UserName,
                                                Title = a.Title,
                                                Content = a.Content,
                                                CreatedOn = a.CreatedOn.ToShortDateString(),
                                                Id = a.Id
                                            })
                                            .FirstOrDefaultAsync();
        }
    }
}
