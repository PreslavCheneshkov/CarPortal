using CarPortal.Core.Services.Contracts;

namespace CarPortal.API.Controllers
{
    public class CarController : CarPortalApiController
    {
        private readonly ICarDataService _carDataService;

        public CarController(ICarDataService carDataService)
        {
            _carDataService = carDataService;
        }
    }
}
