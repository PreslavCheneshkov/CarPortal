using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.CarPortalUserConstants;

namespace CarPortal.API.Models.Identity
{
    public class RegiserUserInputModel
    {
        [Required]
        [StringLength(MaxUserNameLength, MinimumLength = MinUserNameLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(MaxEmailLength, MinimumLength = MinEmailLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(MaxPasswordLength, MinimumLength = MinPasswordLength)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}
