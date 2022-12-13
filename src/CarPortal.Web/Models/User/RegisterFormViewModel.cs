using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.CarPortalUserConstants;
#pragma warning disable CS8618


namespace CarPortal.Web.Models.User
{
    public class RegisterFormViewModel
    {
        [Required]
        [StringLength(MaxUserNameLength, MinimumLength = MinUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(MaxEmailLength, MinimumLength = MinEmailLength)]
        public string Email { get; set; }

        [Required]
        [StringLength (MaxPasswordLength, MinimumLength = MinPasswordLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool IsDealer { get; set; }
    }
}
