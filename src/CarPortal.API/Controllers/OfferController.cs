using CarPortal.API.Models.Offer;
using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data.Entities.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.API.Controllers
{
    public class OfferController : CarPortalApiController
    {
        private readonly IOfferService _offerService;
        private readonly ISearchService _searchService;

        private readonly UserManager<CarPortalUser> _userManager;

        public OfferController(
            IOfferService offerService,
            ISearchService searchService,
            UserManager<CarPortalUser> userManager)
        {
            _offerService = offerService;
            _searchService = searchService;
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Recent()
        {
            var offers = await _offerService.GetRecentOffersAsync();
            var outputOffers = offers.Select(o => MapToOutputModel(o)).ToArray();
            if (outputOffers.Length == 0)
                return NoContent();

            return new JsonResult(outputOffers);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int offerId)
        {
            var offer = await _offerService.GetOfferByIdAsync(offerId);
            if (offer == null) 
                return NoContent();

            var offerOutput = MapToOutputModel(offer);

            return new JsonResult(offerOutput);
        }

        [HttpPost]
        public async Task<IActionResult> AddOffer(AddOfferInputModel offer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var offerServiceModel = MapToServiceModel(offer);
            var userId = (await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == this.User.Identity.Name))?.Id;
            if (userId is null)
                return Unauthorized();

            await _offerService.AddOfferAsync(offerServiceModel, userId);
            return Ok("Successfully added offer.");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Search(SearchOfferInputModel inputModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var searchResults = await _searchService.GetOfferSearchResultsAsync(MapToServiceModel(inputModel));
            if (searchResults.Count == 0)
                return NoContent();

            return new JsonResult(searchResults);
        }

        #region Model mappings

        private SearchModelDto MapToServiceModel(SearchOfferInputModel inputModel)
        {
            if (inputModel is null)
                throw new ArgumentNullException(nameof(inputModel));

            return new SearchModelDto
            {
                ColorIds = inputModel.ColorIds,
                ExtraIds = inputModel.ExtraIds,
                FromDealer = inputModel.FromDealer,
                FuelTypeIds = inputModel.FuelTypeIds,
                Keyword = inputModel.Keyword,
                ManufacturerId = inputModel.ManufacturerId,
                MaxEngineDisplacement = inputModel.MaxEngineDisplacement,
                MaxHorsePower = inputModel.MaxHorsePower,
                MaxMileage = inputModel.MaxMileage,
                MaxPrice = inputModel.MaxPrice,
                MaxYear = inputModel.MaxYear,
                MinEngineDisplacement = inputModel.MinEngineDisplacement,
                MinHorsePower = inputModel.MinHorsePower,
                MinPrice = inputModel.MinPrice,
                MinYear = inputModel.MinYear,
                ModelId = inputModel.ModelId,
                OrderBy = inputModel.OrderBy,
                RegionIds = inputModel.RegionIds,
                TransmissionTypeIds = inputModel.TransmissionTypeIds,
                VehicleCategoryId = inputModel.VehicleCategoryId
            };
        }

        private CarInputModel MapToServiceModel(AddCarInputModel car)
        {
            if (car is null)
                throw new ArgumentNullException(nameof(car));

            return new CarInputModel
            {
                ColorId = car.ColorId,
                EngineDisplacement = car.EngineDisplacement,
                FuelTypeId = car.FuelTypeId,
                HorsePower = car.HorsePower,
                ManufacturerId = car.ManufacturerId,
                Mileage = car.Mileage,
                ModelId = car.ModelId,
                SelectedExtrasIds = car.ExtraIds,
                TransmissionTypeId = car.TransmissionTypeId,
                VehicleCategoryId = car.VehicleCategoryId,
                Year = car.Year,
            };
        }

        private OfferInputModel MapToServiceModel(AddOfferInputModel offer)
        {
            if (offer is null)
                throw new ArgumentNullException(nameof(offer));

            return new OfferInputModel
            {
                Car = MapToServiceModel(offer.Car),
                AdditionalInfo = offer.AdditionalInfo,
                CityId = offer.CityId,
                ContactPhoneNumber = offer.ContactPhoneNumber,
                Images = offer.Images,
                Name = offer.Name,
                Price = offer.Price,
                RegionId = offer.RegionId,
                Thumbnail = offer.Thumbnail,
            };
        }

        private OfferDetailsOutputModel MapToOutputModel(SingleOfferDto offer)
        {
            if (offer is null)
                throw new ArgumentNullException(nameof(offer));

            return new OfferDetailsOutputModel
            {
                Car = MapToOutputModel(offer.CarDto),
                AdditionalInfo = offer.AdditionalInfo,
                City = offer.City,
                ContactPhoneNumber = offer.ContactPhoneNumber,
                Id = offer.Id, 
                LastEdited = offer.LastEdited,
                Name = offer.Name,
                PictureIds = offer.PictureIds.ToList(),
                Price = offer.Price,
                Region = offer.Region,
                SellerId = offer.SellerId,
                SellerName = offer.SellerName,
                ThumbnailUrl = offer.ThumbnailUrl,
            };
        }

        private CarInOfferDetailsOutputModel MapToOutputModel(CarInSingleOfferDto car)
        {
            if (car is null)
                throw new ArgumentNullException(nameof(car));

            return new CarInOfferDetailsOutputModel
            {
                Color = car.Color,
                EngineDisplacement = car.EngineDisplacement,
                Extras = string.Join(", ", car.Extras),
                FuelType = car.FuelType,
                HorsePower = car.HorsePower,
                Manufacturer = car.Manufacturer,
                Mileage = car.Mileage,
                Model = car.Model,
                TransmissionType = car.TransmissionType,
                VehicleCategory = car.VehicleCategory,
                Year = car.Year,
            };
        }

        private OfferInCollectionOutputModel MapToOutputModel(OfferInCollectionDto offer)
        {
            if (offer is null)
                throw new ArgumentNullException(nameof(offer));

            return new OfferInCollectionOutputModel
            {
                FuelType = offer.FuelType,
                HorsePower = offer.HorsePower,
                Manufacturer = offer.Manufacturer,
                Mileage = offer.Mileage,
                Model = offer.Model,
                OfferId = offer.OfferId,
                OfferName = offer.OfferName,
                Price = offer.Price,
                ThumbnailUrl = offer.ThumbnailUrl,
                TransmissionType = offer.TransmissionType,
                Year = offer.Year,
            };
        }

        #endregion
    }
}
