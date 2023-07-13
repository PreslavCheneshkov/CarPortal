namespace CarPortal.API.Models.Offer
{
    public class OfferDetailsOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public CarInOfferDetailsOutputModel Car { get; set; } = null!;

        public decimal Price { get; set; }

        public string SellerId { get; set; } = null!;

        public string SellerName { get; set; } = null!;

        public DateTime LastEdited { get; set; }

        public string Region { get; set; } = null!;

        public string City { get; set; } = null!;

        public string ContactPhoneNumber { get; set; } = null!;

        public string ThumbnailUrl { get; set; } = null!;

        public List<string> PictureIds { get; set; } = new List<string>();

        public string AdditionalInfo { get; set; } = null!;
    }
}
