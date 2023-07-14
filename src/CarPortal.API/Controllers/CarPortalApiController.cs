using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.API.Controllers
{
    [Authorize]
    public abstract class CarPortalApiController : ControllerBase
    {
    }
}
