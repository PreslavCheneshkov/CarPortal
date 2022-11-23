﻿using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data.Entities.User;
using CarPortal.Web.Models.Offer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarPortal.Web.Controllers
{
    public class OfferController : CarPortalController
    {
        private readonly IOfferService offerService;
        private readonly UserManager<CarPortalUser> userManager;

        public OfferController(
            IOfferService _offerService,
            UserManager<CarPortalUser> _userManager
            )
        {
            offerService = _offerService;
            userManager = _userManager;
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
                Thumbnail = model.Thumbnail,
                Images = model.Images,
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

            var user = await userManager.GetUserAsync(this.User);

            await offerService.AddOfferAsync(offer, user.Id);

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
                ThumbnailUrl = o.ThumbnailUrl,
            }).ToList();

            return View(offers);
        }
        [HttpGet]
        public async Task<IActionResult> OfferDetails(int Id)
        {
            var offerDto = await offerService.GetOfferByIdAsync(Id);

            if (offerDto == null)
            {
                return NotFound();
            }

            OfferDetailsViewModel model = new OfferDetailsViewModel()
            {
                Car = new CarInOfferDetailsViewModel()
                {
                    Year = offerDto.CarDto.Year,
                    Model = offerDto.CarDto.Model,
                    Color = offerDto.CarDto.Color,
                    Extras = offerDto.CarDto.Extras,
                    Mileage = offerDto.CarDto.Mileage,
                    FuelType = offerDto.CarDto.FuelType,
                    IsBrandNew = offerDto.CarDto.IsBrandNew,
                    Manufacturer = offerDto.CarDto.Manufacturer,
                    VehicleCategory = offerDto.CarDto.VehicleCategory,
                    TransmissionType = offerDto.CarDto.TransmissionType,
                },
                Id = offerDto.Id,
                City = offerDto.City,
                Region = offerDto.Region,
                SellerId = offerDto.SellerId,
                PictureIds = offerDto.PictureIds.ToList(),
                LastEdited = offerDto.LastEdited,
                SellerName = offerDto.SellerName,
                ThumbnailUrl = offerDto.ThumbnailUrl,
                ContactPhoneNumber = offerDto.ContactPhoneNumber,
            };

            return View(model);
        }
    }
}
