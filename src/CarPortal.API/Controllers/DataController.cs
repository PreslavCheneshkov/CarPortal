using CarPortal.Core.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.API.Controllers
{
    public class DataController : CarPortalApiController
    {
        private readonly IOfferDataService _offerDataService;
        private readonly ICarDataService _carDataService;

        public DataController(IOfferDataService offerDataService, ICarDataService carDataService)
        {
            _offerDataService = offerDataService;
            _carDataService = carDataService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> InitialDropDowns()
        {
            var dropDowns = await _offerDataService.GetDropDownsForAddingOfferAsync();

            return new JsonResult(dropDowns);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> VehicleModels(int? manufacturerId)
        {
            var models = await _carDataService.GetVehicleModelsAsync(manufacturerId);

            return new JsonResult(models);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Cities(int? regionId)
        {
            var cities = await _offerDataService.GetCitiesAsync(regionId);

            return new JsonResult(cities);
        }
    }
}
