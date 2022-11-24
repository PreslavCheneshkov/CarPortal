using CarPortal.Core.Dtos.Offer.DropDownModels;
using CarPortal.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    [Route("api/DropDown")]
    [ApiController]
    public class DropDownController : ControllerBase
    {
        private readonly IDropDownService dropDownService;
        public DropDownController(IDropDownService _dropDownService)
        {
            dropDownService = _dropDownService;
        }
        public async Task<IActionResult> GetModels(int manufacturerId)
        {
            var models = await dropDownService.GetModelsAsync(manufacturerId);

            if (models == null)
            {
                return NotFound();
            }

            return Ok(models);
        }
    }
}
