using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Models.News;
using CarPortal.Web.Models.Offer;
using Ganss.Xss;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarPortal.Web.Controllers
{
    public class CommentsController : CarPortalController
    {
        private readonly ICommentService commentService;
        private readonly HtmlSanitizer htmlSanitizer;

        public CommentsController(
            ICommentService commentService,
            HtmlSanitizer htmlSanitizer
            )
        {
            this.commentService = commentService;
            this.htmlSanitizer = htmlSanitizer;
        }

        [AllowAnonymous]
        [Route("[controller]/offer/{offerId}")]
        [HttpGet]
        public async Task<IActionResult> OfferComments(int offerId)
        {
            var comments = await commentService.GetOfferComments(offerId);

            var commentsViewModel = comments.Select(c => new OfferCommentViewModel
            {
                Author = c.Author,
                Content = c.Content,
                CreatedOn = c.CreatedOn,
                Id = c.Id,
            });

            return View("_CommentsPartial", commentsViewModel);
        }

        [AllowAnonymous]
        [Route("[controller]/article/{articleId}")]
        [HttpGet]
        public async Task<IActionResult> NewsArticleComments(int articleId)
        {
            var comments = await commentService.GetNewsArticleComments(articleId);

            var commentsViewModel = comments.Select(c => new NewsArticleCommentViewModel
            {
                Author = c.Author,
                Content = c.Content,
                CreatedOn = c.CreatedOn,
                Id = c.Id,
            });

            return View("_CommentsPartial", commentsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(NewsArticleDetailsViewModel model, int newsArticleId)
        {
            if (model.NewComment.Content == null || newsArticleId <= 0)
            {
                return BadRequest();
            }

            try
            {
                await commentService.AddCommentToNewsArticle(htmlSanitizer.Sanitize(model.NewComment.Content), this.User.FindFirstValue(ClaimTypes.NameIdentifier), newsArticleId);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(OfferDetailsViewModel model, int offerId)
        {
            if (model.NewComment.Content == null || offerId == null)
            {
                return BadRequest();
            }

            try
            {
                await commentService.AddCommentToOffer(htmlSanitizer.Sanitize(model.NewComment.Content), this.User.FindFirstValue(ClaimTypes.NameIdentifier), offerId);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
