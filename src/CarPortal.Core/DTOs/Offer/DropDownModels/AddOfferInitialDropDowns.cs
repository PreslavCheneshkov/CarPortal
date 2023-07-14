namespace CarPortal.Core.DTOs.Offer.DropDownModels
{
    public class AddOfferInitialDropDowns
    {
        public List<DropDownModel> VehicleCategories { get; set; } = new List<DropDownModel>();

        public List<DropDownModel> Manufacturers { get; set; } = new List<DropDownModel>();

        public List<DropDownModel> FuelTypes { get; set; } = new List<DropDownModel>();

        public List<DropDownModel> TransmissionTypes { get; set; } = new List<DropDownModel>();

        public List<DropDownModel> Colors { get; set; } = new List<DropDownModel>();

        public List<DropDownModel> Extras { get; set; } = new List<DropDownModel>();

        public List<DropDownModel> Regions { get; set; } = new List<DropDownModel>();
    }
}
