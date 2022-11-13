namespace CarPortal.Web.Models.Offer
#pragma warning disable

{
    public class GetOfferByIdViewModel
    {
        public int Id { get; set; }

        public CarInOfferByIdViewModel Car { get; set; }

        public string SellerId { get; set; }

        public string SellerName { get; set; }

        public DateTime LastEdited { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ThumbnailName { get; set; }

        public IEnumerable<string> PictureIds { get; set; } = new List<string>();
    }
}
