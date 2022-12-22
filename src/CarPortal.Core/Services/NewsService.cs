using CarPortal.Core.DTOs.News;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.News;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly CarPortalDbContext context;

        public NewsService(CarPortalDbContext context)
        {
            this.context = context;
        }

        public async Task AddCommentToNewsArticle(string content, string authorUserId, int newsArticleId)
        {
            string authorProfileId = await context.Users
                                                    .Where(u => u.Id == authorUserId)
                                                    .Select(u => u.ProfileId)
                                                    .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(authorProfileId) || string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException();
            }

            NewsArticleComment comment = new NewsArticleComment()
            {
                CommenterId = authorProfileId,
                Content = content,
                NewsArticleId = newsArticleId,
                CreatedOn = DateTime.Now,
            };

            await context.NewsArticleComments.AddAsync(comment);
            await context.SaveChangesAsync();
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
                                                Id = a.Id,
                                                Comments = a.Comments.Select(c => new NewsArticleCommentDTO()
                                                {
                                                    Author = c.Commenter.CarPortalUser.UserName,
                                                    Content = c.Content,
                                                    CreatedOn = c.CreatedOn.ToShortDateString(),
                                                }).ToList()
                                            })
                                            .FirstOrDefaultAsync();
        }
    }
}
