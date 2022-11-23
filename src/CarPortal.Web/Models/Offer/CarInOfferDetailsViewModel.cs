namespace CarPortal.Web.Models.Offer
#pragma warning disable

{
    public class CarInOfferDetailsViewModel
    {
        public string VehicleCategory { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string FuelType { get; set; }

        public string TransmissionType { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public IEnumerable<string> Extras { get; set; } = new List<string>();

        public bool IsBrandNew { get; set; }
    }
}
