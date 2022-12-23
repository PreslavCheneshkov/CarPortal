using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Areas.Administration.Models;
using CarPortal.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Administration")]
    public class UserManagementController : CarPortalController
    {
        private readonly IAdminService adminService;

        public UserManagementController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new UserRoleViewModel();

            var data = await this.adminService.GetRolesAsync();
            model.AvailableRoles = data;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GiveRole(UserRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.RoleName))
            {
                return BadRequest();
            }

            try
            {
                await this.adminService.GiveRole(model.RoleName, model.Username);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return RedirectToAction("Index", "Home", new { area = "Administration" });
        }
    }
}
