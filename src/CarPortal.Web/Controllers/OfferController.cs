using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Models.Offer;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarPortal.Web.Controllers
{
    public class OfferController : CarPortalController
    {
        private readonly IOfferService offerService;
        public OfferController(IOfferService _offerService)
        {
            offerService = _offerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddOffer()
        {
            var dropdowns = await offerService.PopulateViewModelWithDropDownsAsync();
            var model = new AddOfferViewModel()
            {
                Regions = dropdowns.Regions,
                Cities = dropdowns.Cities,
                Car = new AddCarViewModel 
                {
                    VehicleCategories = dropdowns.VehicleCategories,
                    Manufacturers = dropdowns.Manufacturers,
                    VehicleModels = dropdowns.VehicleModels,
                    FuelTypes = dropdowns.FuelTypes,
                    TransmissionTypes = dropdowns.TransmissionTypes,
                    Colors = dropdowns.Colors,
                }
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddOffer(AddOfferViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var offer = new OfferInputModel
            {
                Price = model.Price,
                CityId = model.CityId,
                RegionId = model.RegionId,
                AdditionalInfo = model.AdditionalInfo,
                ContactPhoneNumber = model.ContactPhoneNumber,
                Car = new CarInputModel()
                {
                    VehicleCategoryId = model.Car.VehicleCategoryId,
                    ManufacturerId = model.Car.ManufacturerId,
                    ModelId = model.Car.ModelId,
                    FuelTypeId = model.Car.FuelTypeId,
                    TransmissionTypeId = model.Car.TransmissionTypeId,
                    ColorId = model.Car.ColorId,
                    EngineDisplacement = model.Car.EngineDisplacement,
                    Mileage = model.Car.Mileage,
                    Year = model.Car.Year,
                    IsBrandNew = model.Car.IsBrandNew,
                }
            };

            string userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

            await offerService.AddOfferAsync(offer, userId);

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> SeeAll()
        {
            var offers = (await offerService.GetAllOffers()).Select(o => new SeeAllOffersViewModel() 
            {
                Manufacturer = o.Manufacturer,
                Model = o.Model,
                FuelType = o.FuelType,
                Year = o.Year,
                Price = o.Price,
                Mileage = o.Mileage,
                ContactPhone = o.ContactPhone,
            }).ToList();

            return View(offers);
        }
    }
}
