using CarPortal.Core.Services.Contracts;
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
                return View(model);
            }

            throw new NotImplementedException();
        }
    }
}
