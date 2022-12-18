using CarPortal.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Administration")]
    public class AdminController : CarPortalController
    {
        public IActionResult AdministratorIndex()
        {
            return View("~/Areas/Administration/Views/Admin/AdministratorIndex.cshtml");
        }
        [Route("/AdministratorIndex")]
        public IActionResult NewsWriterIndex()
        {
            return View();
        }
    }
}
