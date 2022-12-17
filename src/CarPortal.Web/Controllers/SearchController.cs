using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Models.Offer;
using CarPortal.Web.Models.Search;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    public class SearchController : CarPortalController
    {
        private readonly ISearchService searchService;
        private readonly IPageDataService pageDataService;

        public SearchController(IPageDataService pageDataService, ISearchService searchService)
        {
            this.pageDataService = pageDataService;
            this.searchService = searchService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> CustomSearch()
        {
            var pageData = await this.pageDataService.PopulateSearchModelAsync();
            var model = new SearchInputViewModel()
            {
                //dropdowns
                VehicleCategories = pageData.VehicleCategories,
                Manufacturers = pageData.Manufacturers,
                VehicleModels = pageData.VehicleModels,
                //checkboxes
                Regions = pageData.Regions,
                Colors = pageData.Colors,
                FuelTypes = pageData.FuelTypes,
                TransmissionTypes = pageData.TransmissionTypes,
                Extras = pageData.Extras,
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CustomSearch(SearchInputViewModel model, int[] extraIds, int[] colorIds, int[] fuelTypeIds, int[] transmissionTypeIds, int[] regionIds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
                //return View(model);
            }

            SearchModelDto searchModel = new SearchModelDto()
            {
                VehicleCategoryId = model.VehicleCategoryId,
                ManufacturerId = model.ManufacturerId,
                ModelId = model.ModelId,
                MaxEngineDisplacement = model.MaxEngineDisplacement,
                MinEngineDisplacement = model.MinEngineDisplacement,
                MaxHorsePower = model.MaxHorsePower,
                MinHorsePower = model.MinHorsePower,
                FuelTypeIds = fuelTypeIds,
                TransmissionTypeIds = transmissionTypeIds,
                MaxYear = model.MaxYear,
                MinYear = model.MinYear,
                MaxMileage = model.MaxMileage,
                MaxPrice = model.MaxPrice,
                MinPrice = model.MinPrice,
                ExtraIds = extraIds,
                ColorIds = colorIds,
                RegionIds = regionIds,
                Keyword = model.Keyword,
                FromDealer = model.FromDealer,
                OrderBy= model.OrderBy,
            };

            var results = await this.searchService.GetSearchResultsAsync(searchModel);

            var viewModel = results.Select(o => new OfferInCollectionViewModel()
            {
                TransmissionType = o.TransmissionType,
                FuelType = o.FuelType,
                HorsePower = o.HorsePower,
                Manufacturer = o.Manufacturer,
                Mileage = o.Mileage,
                Model = o.Model,
                OfferId = o.OfferId,
                OfferName = o.OfferName,
                Price = o.Price,
                ThumbnailUrl = o.ThumbnailUrl,
                Year = o.Year,
            }).ToList();

            return View("SearchResultCollection", viewModel);
        }
    }
}
