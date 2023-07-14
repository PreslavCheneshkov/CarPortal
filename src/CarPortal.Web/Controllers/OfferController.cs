using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data.Entities.User;
using CarPortal.Web.Models.News;
using CarPortal.Web.Models.Offer;
using Ganss.Xss;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarPortal.Web.Controllers
{
    public class OfferController : CarPortalController
    {
        private readonly UserManager<CarPortalUser> _userManager;
        private readonly IOfferService _offerService;
        private readonly IPageDataService _pageDataService;
        private readonly HtmlSanitizer _sanitizer;

        public OfferController(
            UserManager<CarPortalUser> userManager,
            IOfferService offerService,
            IPageDataService pageDataService
            )
        {
            _offerService = offerService;
            _userManager = userManager;
            _pageDataService = pageDataService;
            _sanitizer = new HtmlSanitizer();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var dropdowns = await _pageDataService.PopulateViewModelWithDropDownsAsync();

            var model = new AddOfferViewModel()
            {
                Regions = dropdowns.Regions,
                Car = new AddCarViewModel
                {
                    Extras = dropdowns.Extras,
                    VehicleCategories = dropdowns.VehicleCategories,
                    Manufacturers = dropdowns.Manufacturers,
                    FuelTypes = dropdowns.FuelTypes,
                    TransmissionTypes = dropdowns.TransmissionTypes,
                    Colors = dropdowns.Colors,
                }
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOfferViewModel model, int[] carExtras)
        {
            if (!ModelState.IsValid)
            {
                var dropdowns = await _pageDataService.PopulateViewModelWithDropDownsAsync();
                model = new AddOfferViewModel()
                {
                    Regions = dropdowns.Regions,
                    Car = new AddCarViewModel
                    {
                        Extras = dropdowns.Extras,
                        VehicleCategories = dropdowns.VehicleCategories,
                        Manufacturers = dropdowns.Manufacturers,
                        FuelTypes = dropdowns.FuelTypes,
                        TransmissionTypes = dropdowns.TransmissionTypes,
                        Colors = dropdowns.Colors,
                    }
                };

                return View(model);
            }

            var offer = new OfferInputModel
            {
                Name = _sanitizer.Sanitize(model.Name),
                Price = model.Price,
                CityId = model.CityId,
                RegionId = model.RegionId,
                AdditionalInfo = _sanitizer.Sanitize(model.AdditionalInfo),
                ContactPhoneNumber = _sanitizer.Sanitize(model.ContactPhoneNumber),
                Thumbnail = model.Thumbnail,
                Images = model.Images,
                Car = new CarInputModel()
                {
                    SelectedExtrasIds = carExtras.ToList(),
                    VehicleCategoryId = model.Car.VehicleCategoryId,
                    ManufacturerId = model.Car.ManufacturerId,
                    ModelId = model.Car.ModelId,
                    FuelTypeId = model.Car.FuelTypeId,
                    TransmissionTypeId = model.Car.TransmissionTypeId,
                    ColorId = model.Car.ColorId,
                    EngineDisplacement = model.Car.EngineDisplacement,
                    HorsePower = model.Car.HorsePower,
                    Mileage = model.Car.Mileage,
                    Year = model.Car.Year,
                    IsBrandNew = model.Car.IsBrandNew,
                }
            };

            var user = await _userManager.GetUserAsync(this.User);

            try
            {
                await _offerService.AddOfferAsync(offer, user.Id);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public async Task<IActionResult> BrowseRecent()
        {
            var offers = (await _offerService.GetRecentOffersAsync()).Select(o => new OfferInCollectionViewModel()
            {
                OfferId = o.OfferId,
                OfferName = o.OfferName,
                Manufacturer = o.Manufacturer,
                Model = o.Model,
                FuelType = o.FuelType,
                HorsePower = o.HorsePower,
                Year = o.Year,
                Price = o.Price,
                Mileage = o.Mileage,
                TransmissionType = o.TransmissionType,
                ThumbnailUrl = o.ThumbnailUrl,
            }).ToList();

            return View(offers);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var offerDto = await _offerService.GetOfferByIdAsync(id);

            if (offerDto == null)
            {
                return NotFound();
            }

            if (!offerDto.IsActive)
            {
                return NotFound();
            }

            OfferDetailsViewModel model = new OfferDetailsViewModel()
            {
                Car = new CarInOfferDetailsViewModel()
                {
                    HorsePower = offerDto.CarDto.HorsePower,
                    EngineDisplacement = offerDto.CarDto.EngineDisplacement,
                    Year = offerDto.CarDto.Year,
                    Model = offerDto.CarDto.Model,
                    Color = offerDto.CarDto.Color,
                    Extras = string.Join(", ", offerDto.CarDto.Extras),
                    Mileage = offerDto.CarDto.Mileage,
                    FuelType = offerDto.CarDto.FuelType,
                    IsBrandNew = offerDto.CarDto.IsBrandNew,
                    Manufacturer = offerDto.CarDto.Manufacturer,
                    VehicleCategory = offerDto.CarDto.VehicleCategory,
                    TransmissionType = offerDto.CarDto.TransmissionType,
                },
                Id = offerDto.Id,
                Name = offerDto.Name,
                Price = offerDto.Price,
                City = offerDto.City,
                Region = offerDto.Region,
                SellerId = offerDto.SellerId,
                PictureIds = offerDto.PictureIds.ToList(),
                LastEdited = offerDto.LastEdited,
                SellerName = offerDto.SellerName,
                ThumbnailUrl = offerDto.ThumbnailUrl,
                AdditionalInfo = offerDto.AdditionalInfo,
                ContactPhoneNumber = offerDto.ContactPhoneNumber,
                NewComment = new OfferCommentInputModel(),
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            SingleOfferDto offer;
            try
            {
                offer = await _offerService.GetOfferByIdAsync(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            if (offer == null)
            {
                return NotFound();
            }

            if (offer.SellerId != this.User.FindFirstValue(ClaimTypes.NameIdentifier) && !this.User.IsInRole("Administrator"))
            {
                return Forbid();
            }

            await _offerService.Delete(id);

            if (this.User.IsInRole("Administrator"))
            {
                return RedirectToAction("Index", "Home", new { area = "Administration" });
            }

            return RedirectToAction("MyProfile", "User");
        }
    }
}
