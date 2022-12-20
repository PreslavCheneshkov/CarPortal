﻿using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data.Entities.User;
using CarPortal.Web.Models.News;
using CarPortal.Web.Models.Offer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarPortal.Web.Controllers
{
    public class OfferController : CarPortalController
    {
        private readonly UserManager<CarPortalUser> userManager;
        private readonly IOfferService offerService;
        private readonly IPageDataService pageDataService;

        public OfferController(
            UserManager<CarPortalUser> userManager,
            IOfferService offerService,
            IPageDataService pageDataService
            )
        {
            this.offerService = offerService;
            this.userManager = userManager;
            this.pageDataService = pageDataService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddOffer()
        {
            var dropdowns = await pageDataService.PopulateViewModelWithDropDownsAsync();

            var model = new AddOfferViewModel()
            {
                Regions = dropdowns.Regions,
                Cities = dropdowns.Cities,
                Car = new AddCarViewModel
                {
                    Extras = dropdowns.Extras,
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
        public async Task<IActionResult> AddOffer(AddOfferViewModel model, int[] carExtras)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var offer = new OfferInputModel
            {
                Name = model.Name,
                Price = model.Price,
                CityId = model.CityId,
                RegionId = model.RegionId,
                AdditionalInfo = model.AdditionalInfo,
                ContactPhoneNumber = model.ContactPhoneNumber,
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

            var user = await userManager.GetUserAsync(this.User);

            await offerService.AddOfferAsync(offer, user.Id);

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public async Task<IActionResult> BrowseRecent(int page = 0)
        {
            var offers = (await offerService.GetRecentOffersAsync(page)).Select(o => new OfferInCollectionViewModel()
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
        public async Task<IActionResult> OfferDetails(int id)
        {
            var offerDto = await offerService.GetOfferByIdAsync(id);

            if (offerDto == null)
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
                Comments = offerDto.Comments.Select(c => new OfferCommentViewModel()
                {
                    Id = c.Id,
                    Author = c.Author,
                    Content = c.Content,
                    CreatedOn = c.CreatedOn,
                }).ToList(),
                NewComment = new OfferCommentInputModel(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(OfferDetailsViewModel model, int offerId)
        {
            if (model.NewComment.Content == null || offerId == null)
            {
                return BadRequest();
            }

            try
            {
                await this.offerService.AddCommentToOffer(model.NewComment.Content, this.User.FindFirstValue(ClaimTypes.NameIdentifier), offerId);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(OfferDetails), "Offer", new { id = offerId });
        }

        public async Task<IActionResult> AddToInterestedIn(int id)
        {
            return NoContent();
        }
    }
}
