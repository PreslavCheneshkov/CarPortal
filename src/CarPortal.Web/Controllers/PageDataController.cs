using CarPortal.Core.DTOs.API;
using CarPortal.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageDataController : ControllerBase
    {
        private readonly IPageDataService service;

        public PageDataController(IPageDataService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("models")]
        public async Task<IActionResult> GetModels(string id)
        {
            bool isInt = int.TryParse(id, out int manufacturerId);

            if (!isInt)
            {
                return BadRequest();
            }

            var models = await this.service.GetModelsAsync(manufacturerId);

            if (models == null || models.Count == 0)
            {
                return NotFound();
            }

            var model = new VehicleModelCollectionDTO()
            {
                ModelCollection = models.OrderBy(x => x.Name).ToList(),
            };

            return Ok(model);
        }

        [HttpGet]
        [Route("cities")]
        public async Task<IActionResult> GetCities(string id)
        {
            bool isInt = int.TryParse(id, out int regionId);

            if (!isInt)
            {
                return BadRequest();
            }

            var cities = await this.service.GetCitiesAsync(regionId);

            if (cities == null || cities.Count == 0)
            {
                return NotFound();
            }

            var model = new CityCollectionDto()
            {
                CityCollection = cities,
            };

            return Ok(model);
        }
    }
}
