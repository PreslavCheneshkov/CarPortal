using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Models;
using CarPortal.Web.Models.Home;
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

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}