using CarPortal.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Administration")]
    public class HomeController : CarPortalController
    {
        public IActionResult Index()
        {
            return View("~/Areas/Administration/Views/Home/Index.cshtml");
        }
    }
}
