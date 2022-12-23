using Microsoft.Build.Framework;

namespace CarPortal.Web.Areas.Administration.Models
{
    public class UserRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }

        [Required]
        public string Username { get; set; }

        public List<string> AvailableRoles { get; set; } = new List<string>();
    }
}
