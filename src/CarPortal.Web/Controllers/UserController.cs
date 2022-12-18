using CarPortal.Core.DTOs.Profile;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data.Entities.User;
using CarPortal.Web.Models.Offer;
using CarPortal.Web.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    public class UserController : CarPortalController
    {
        private readonly SignInManager<CarPortalUser> signInManager;
        private readonly UserManager<CarPortalUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IProfileService profileService;

        public UserController(SignInManager<CarPortalUser> signInManager,
            UserManager<CarPortalUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IProfileService profileService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.profileService = profileService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            RegisterFormViewModel model = new RegisterFormViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterFormViewModel model)
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new CarPortalUser()
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await this.profileService.CreateProfileAsync(model.UserName, model.IsDealer);

                return RedirectToAction("Login", "User");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            LoginFormViewModel model = new LoginFormViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginFormViewModel model)
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    if (await userManager.IsInRoleAsync(user, "Administrator"))
                    {
                        return RedirectToAction("AdministratorIndex", "Admin", new { area = "Administration"});
                    }
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var data = await this.profileService.GetProfileByUsernameAsync(this.User.Identity.Name);

            ProfileViewModel model = new ProfileViewModel()
            {
                ProfilePictureAddress = data.ProfilePictureAddress,
                UserName = data.UserName,
                ProfileId = data.ProfileId,
                IsDealer = data.IsDealer,
                CreatedOn = data.CreatedOn,
                //SavedOffers = data.SavedOffers.Select(so => new OfferInCollectionViewModel()
                //{
                //    FuelType = so.FuelType,
                //    HorsePower = so.HorsePower,
                //    Manufacturer = so.Manufacturer,
                //    Mileage = so.Mileage,
                //    Model = so.Model,
                //    OfferId = so.OfferId,
                //    OfferName = so.OfferName,
                //    Price = so.Price,
                //    ThumbnailUrl = so.ThumbnailUrl,
                //    TransmissionType = so.TransmissionType,
                //    Year = so.Year,
                //}).ToList(),
                UploadedOffers = data.UploadedOffers.Select(uo => new OfferInCollectionViewModel()
                {
                    FuelType = uo.FuelType,
                    HorsePower = uo.HorsePower,
                    Manufacturer = uo.Manufacturer,
                    Mileage = uo.Mileage,
                    Model = uo.Model,
                    OfferId = uo.OfferId,
                    OfferName = uo.OfferName,
                    Price = uo.Price,
                    ThumbnailUrl = uo.ThumbnailUrl,
                    TransmissionType = uo.TransmissionType,
                    Year = uo.Year,
                }).ToList(),
            };

            return View("UserProfile", model);
        }
    }
}
