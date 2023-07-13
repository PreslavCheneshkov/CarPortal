using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.CarPortalUserConstants;

namespace CarPortal.API.Models.Identity
{
    public class LoginUserInputModel
    {
        [Required]
        [StringLength(MaxUserNameLength, MinimumLength = MinUserNameLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(MaxPasswordLength, MinimumLength = MinPasswordLength)]
        public string Password { get; set; } = null!;
    }
}
