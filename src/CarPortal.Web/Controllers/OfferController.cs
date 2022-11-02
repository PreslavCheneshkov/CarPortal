using CarPortal.Web.Models.Offer;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    public class OfferController : CarPortalController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddOffer()
        {
            var model = new AddOfferViewModel();

            return View(model);
        }
    }
}
