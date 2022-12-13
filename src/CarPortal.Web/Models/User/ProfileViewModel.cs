﻿using System.ComponentModel.DataAnnotations;

namespace CarPortal.Web.Models.User
{
    public class ProfileViewModel
    {
        public string ProfileId { get; set; }

        public string UserName { get; set; }

        public bool IsDealer { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedOn { get; set; }

        public string? ProfilePictureAddress { get; set; }
    }
}
