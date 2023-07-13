using CarPortal.Core.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.API.Controllers
{
    public class HomeController : CarPortalApiController
    {
        private readonly IOfferService _offerService;

        public HomeController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var recentOffers = await _offerService.GetRecentOffersAsync();

            var offerNames = recentOffers.Select(o => o.OfferName).ToList();

            return Ok($"Home/Index works{Environment.NewLine}{string.Join(", ", offerNames)}");
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return Ok("Home/Privacy works");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Ok();
        }
    }
}