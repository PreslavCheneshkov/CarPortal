using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.User
{
    public class ProfilePicture
    {
        public ProfilePicture()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CarPortalUser))]
        public string CarPortalUserId { get; set; } = null!;

        [Required]
        public string Extension { get; set; } = null!;
    }
}
