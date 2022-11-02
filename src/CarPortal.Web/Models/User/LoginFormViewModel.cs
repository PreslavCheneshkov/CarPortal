using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.CarPortalUserConstants;
#pragma warning disable CS8618

namespace CarPortal.Web.Models.User
{
    public class LoginFormViewModel
    {
        [Required]
        [StringLength(MaxUserNameLength, MinimumLength = MinUserNameLength)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(MaxPasswordLength, MinimumLength = MinPasswordLength)]
        public string Password { get; set; }
    }
}
