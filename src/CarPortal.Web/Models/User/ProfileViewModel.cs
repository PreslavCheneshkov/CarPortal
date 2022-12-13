namespace CarPortal.Web.Models.User
{
    public class ProfileViewModel
    {
        public string ProfileId { get; set; }

        public string UserName { get; set; }

        public bool IsDealer { get; set; }

        public string? ProfilePictureAddress { get; set; }
    }
}
