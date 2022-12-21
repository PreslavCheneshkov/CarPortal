using CarPortal.Core.DTOs.API;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.WebApi.Controllers
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
        public async Task<IActionResult> GetModels(string id)
        {
            int manufacturerId = int.Parse(id);

            var models = await this.service.GetModelsAsync(manufacturerId);

            var model = new VehicleModelCollectionDTO()
            {
                ModelCollection = models,
            };

            return Ok(model);
        }
    }
}
