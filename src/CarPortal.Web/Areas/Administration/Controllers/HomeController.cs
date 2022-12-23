using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Areas.Administration.Models;
using CarPortal.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Administration")]
    public class HomeController : CarPortalController
    {
        private readonly IAdminService adminService;

        public HomeController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await this.adminService.GetIndexPageDataAsync();

            AdminStatsViewModel model = new AdminStatsViewModel()
            {
                OfferCount = data.Item1,
                UserCount = data.Item2,
            };

            return View("~/Areas/Administration/Views/Home/Index.cshtml", model);
        }
    }
}
