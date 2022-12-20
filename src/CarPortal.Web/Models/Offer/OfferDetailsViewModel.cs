namespace CarPortal.Web.Models.Offer
#pragma warning disable

{
    public class OfferDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CarInOfferDetailsViewModel Car { get; set; }

        public decimal Price { get; set; }

        public string SellerId { get; set; }

        public string SellerName { get; set; }

        public DateTime LastEdited { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ThumbnailUrl { get; set; }

        public List<string> PictureIds { get; set; } = new List<string>();

        public string AdditionalInfo { get; set; }

        public List<OfferCommentViewModel> Comments { get; set; } = new List<OfferCommentViewModel>();

        public OfferCommentInputModel NewComment { get; set; }
    }
}
