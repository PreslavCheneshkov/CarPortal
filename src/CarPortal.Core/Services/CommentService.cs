using CarPortal.Core.DTOs.News;
using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.News;
using CarPortal.Data.Entities.Offer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable

namespace CarPortal.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly CarPortalDbContext dbContext;

        public CommentService(CarPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddCommentToOffer(string content, string authorUserId, int offerId)
        {
            string authorProfileId = await dbContext.Users
                                                    .Where(u => u.Id == authorUserId)
                                                    .Select(u => u.ProfileId)
                                                    .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(authorProfileId) || string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException();
            }

            OfferComment comment = new OfferComment()
            {
                CarPortalProfileId = authorProfileId,
                Content = content,
                OfferId = offerId,
                CreatedOn = DateTime.Now,
            };

            await dbContext.OfferComments.AddAsync(comment);
            await dbContext.SaveChangesAsync();
        }

        public async Task AddCommentToNewsArticle(string content, string authorUserId, int newsArticleId)
        {
            string authorProfileId = await dbContext.Users
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

            await dbContext.NewsArticleComments.AddAsync(comment);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<NewsArticleCommentDTO>> GetNewsArticleComments(int newsArticleId)
            => await dbContext.NewsArticleComments
                            .Where(c => c.NewsArticleId == newsArticleId)
                            .Select(c => new NewsArticleCommentDTO
                            {
                                Author = c.Commenter.CarPortalUser.UserName,
                                Content = c.Content,
                                CreatedOn = c.CreatedOn.ToShortDateString(),
                                Id = c.Id
                            })
                            .ToArrayAsync();

        public async Task<IEnumerable<OfferCommentDTO>> GetOfferComments(int offerId)
            => await dbContext.OfferComments
                                .Where(c => c.OfferId == offerId)
                                .Select(c => new OfferCommentDTO
                                {
                                    Author = c.CarPortalProfile.CarPortalUser.UserName,
                                    Content = c.Content,
                                    CreatedOn = c.CreatedOn.ToShortDateString(),
                                    Id = c.Id
                                })
                                .ToArrayAsync();
    }
}
