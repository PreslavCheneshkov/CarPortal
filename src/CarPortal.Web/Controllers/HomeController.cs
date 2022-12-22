using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Models;
using CarPortal.Web.Models.Home;
using CarPortal.Web.Models.News;
using CarPortal.Web.Models.Offer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarPortal.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOfferService offerService;
        private readonly INewsService newsService;

        public HomeController(
            ILogger<HomeController> logger,
            INewsService newsService,
            IOfferService offerService)
        {
            _logger = logger;
            this.newsService = newsService;
            this.offerService = offerService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel();
            model.RecentOffers = (await this.offerService.GetRecentOffersAsync())
                                                                                .Select(o => new OfferInCollectionViewModel()
                                                                                {
                                                                                    FuelType = o.FuelType,
                                                                                    HorsePower = o.HorsePower,
                                                                                    Manufacturer = o.Manufacturer,
                                                                                    Mileage = o.Mileage,
                                                                                    Model = o.Model,
                                                                                    OfferId = o.OfferId,
                                                                                    OfferName = o.OfferName,
                                                                                    Price = o.Price,
                                                                                    ThumbnailUrl = o.ThumbnailUrl,
                                                                                    TransmissionType = o.TransmissionType,
                                                                                    Year = o.Year,
                                                                                })
                                                                                .Take(4)
                                                                                .ToList();

            model.RecentNewsArticles = (await this.newsService.GetMostRecentArticles())
                                                                                .Select(a => new NewsArticleInCollectionViewModel()
                                                                                {
                                                                                    Author = a.Author,
                                                                                    Content = a.Content,
                                                                                    CreatedOn = a.CreatedOn,
                                                                                    Id = a.Id,
                                                                                    Title = a.Title,
                                                                                })
                                                                                .Take(2)
                                                                                .ToList();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}