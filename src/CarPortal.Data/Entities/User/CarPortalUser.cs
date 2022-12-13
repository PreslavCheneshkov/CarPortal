using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPortal.Data.Entities.User
{
    public class CarPortalUser : IdentityUser
    {
        [ForeignKey(nameof(CarPortalProfile))]
        public string? ProfileId { get; set; }

        public CarPortalProfile? Profile { get; set; }
    }
}
