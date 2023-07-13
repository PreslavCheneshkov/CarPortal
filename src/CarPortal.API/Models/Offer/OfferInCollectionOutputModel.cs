namespace CarPortal.API.Models.Offer
{
    public class OfferInCollectionOutputModel
    {
        public int OfferId { get; set; }

        public string OfferName { get; set; } = null!;

        public string ThumbnailUrl { get; set; } = null!;

        public string Manufacturer { get; set; } = null!;

        public string Model { get; set; } = null!; 

        public decimal Price { get; set; }

        public int Year { get; set; }

        public int? HorsePower { get; set; }

        public string TransmissionType { get; set; } = null!;

        public string FuelType { get; set; } = null!; 

        public int Mileage { get; set; }
    }
}
