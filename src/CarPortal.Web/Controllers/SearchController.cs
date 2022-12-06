using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    public class SearchController : CarPortalController
    {
        public IActionResult CustomSearch()
        {
            return View();
        }
    }
}
