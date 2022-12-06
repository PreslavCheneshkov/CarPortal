using Microsoft.AspNetCore.Identity;

namespace CarPortal.Data.Entities.User
{
    public class CarPortalUser : IdentityUser
    {
        public string? ProfilePictureAddress { get; set; }
    }
}
