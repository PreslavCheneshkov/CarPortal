using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using CarPortal.Web.Models.Offer;
using CarPortal.Web.Models.Search;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ganss.Xss;

namespace CarPortal.Web.Controllers
{
    public class SearchController : CarPortalController
    {
        private readonly ISearchService searchService;
        private readonly IPageDataService pageDataService;
        private readonly HtmlSanitizer sanitizer;

        public SearchController(IPageDataService pageDataService, ISearchService searchService)
        {
            this.pageDataService = pageDataService;
            this.searchService = searchService;
            this.sanitizer = new HtmlSanitizer();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Offers()
        {
            var pageData = await this.pageDataService.PopulateSearchModelAsync();
            var model = new SearchInputViewModel()
            {
                //dropdowns
                VehicleCategories = pageData.VehicleCategories,
                Manufacturers = pageData.Manufacturers,
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
        public async Task<IActionResult> Offers(SearchInputViewModel model, int[] extraIds, int[] colorIds, int[] fuelTypeIds, int[] transmissionTypeIds, int[] regionIds)
        {
            if (!ModelState.IsValid)
            {
                var pageData = await this.pageDataService.PopulateSearchModelAsync();
                model = new SearchInputViewModel()
                {
                    //dropdowns
                    VehicleCategories = pageData.VehicleCategories,
                    Manufacturers = pageData.Manufacturers,
                    //checkboxes
                    Regions = pageData.Regions,
                    Colors = pageData.Colors,
                    FuelTypes = pageData.FuelTypes,
                    TransmissionTypes = pageData.TransmissionTypes,
                    Extras = pageData.Extras,
                };
                return View(model);
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
                Keyword = sanitizer.Sanitize(model.Keyword?? string.Empty),
                FromDealer = model.FromDealer,
                OrderBy= model.OrderBy,
            };

            var results = await this.searchService.GetOfferSearchResultsAsync(searchModel);

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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Dealers()
        {
            var model = new DealerSearchViewModel();
            model.Dealers = await this.searchService.GetDealerSearchResultsAsync(string.Empty);

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Dealers(DealerSearchViewModel model)
        {
            model.Dealers = await this.searchService.GetDealerSearchResultsAsync(this.sanitizer.Sanitize(model.Name));

            return View(model);
        }
    }
}
