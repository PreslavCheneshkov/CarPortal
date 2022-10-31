using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPortal.Web.Controllers
{
    [Authorize]
    public class CarPortalController : Controller
    {
    }
}
