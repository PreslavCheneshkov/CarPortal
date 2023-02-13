using CarPortal.Core.DTOs.News;
using CarPortal.Core.Services;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data.EntityConfigurations.NewsArticleConfigurations;
using CarPortal.Web.Models.News;
using Ganss.Xss;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarPortal.Web.Controllers
{
    public class NewsController : CarPortalController
    {
        private readonly INewsService newsService;
        private readonly HtmlSanitizer sanitizer;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
            this.sanitizer = new HtmlSanitizer();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var mostRecentNews = await this.newsService.GetMostRecentArticles();

            var model = mostRecentNews.Select(a => new NewsArticleInCollectionViewModel()
            {
                Author = a.Author,
                CreatedOn = a.CreatedOn,
                Id = a.Id,
                Title = a.Title,
            }).ToList();

            return View(model);
        }

        [Authorize(Roles = "NewsWriter")]
        [HttpGet]
        public IActionResult WriteArticle()
        {
            var model = new NewsArticleInputViewModel();

            return View(model);
        }

        [Authorize(Roles = "NewsWriter")]
        [HttpPost]
        public async Task<IActionResult> WriteArticle(NewsArticleInputViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.newsService.CreateArticleAsync(new NewsArticleInputDTO()
                {
                    Title = sanitizer.Sanitize(model.Title),
                    Content = sanitizer.Sanitize(model.Content),
                }, this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return RedirectToAction("Index", "News");
        }

        [AllowAnonymous]
        public async Task<IActionResult> NewsArticleDetails(int id)
        {
            var article = await this.newsService.GetNewsArticleDetailsAsync(id);

            if (article == null)
            {
                return BadRequest();
            }

            NewsArticleDetailsViewModel model = new NewsArticleDetailsViewModel()
            {
                Title = article.Title,
                Author = article.Author,
                Content = article.Content,
                CreatedOn = article.CreatedOn,
                Id = id,
                NewComment = new NewCommentInputModel()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var article = await this.newsService.GetNewsArticleDetailsAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            if (article.Author != this.User.Identity.Name)
            {
                return Forbid();
            }

            NewsArticleInputViewModel model = new NewsArticleInputViewModel()
            {
                Content = article.Content,
                Title = article.Title,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewsArticleInputViewModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var article = await this.newsService.GetNewsArticleDetailsAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            if (article.Author != this.User.Identity.Name)
            {
                return Forbid();
            }

            NewsArticleInputDTO dto = new NewsArticleInputDTO()
            {
                Content = this.sanitizer.Sanitize(model.Content),
                Title = sanitizer.Sanitize(model.Title),
            };

            try
            {
                await this.newsService.EditArticleAsync(dto, id);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return RedirectToAction("NewsArticleDetails", new { id = id});
        }
    }
}
