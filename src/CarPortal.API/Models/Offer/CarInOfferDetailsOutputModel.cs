namespace CarPortal.API.Models.Offer
{
    public class CarInOfferDetailsOutputModel
    {
        public string VehicleCategory { get; set; } = null!;

        public string Manufacturer { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string FuelType { get; set; } = null!;

        public double? EngineDisplacement { get; set; }

        public int? HorsePower { get; set; }

        public string TransmissionType { get; set; } = null!;

        public string Color { get; set; } = null!;

        public int Year { get; set; }

        public int Mileage { get; set; }

        public string Extras { get; set; } = null!;

        public bool IsBrandNew { get; set; }
    }
}
