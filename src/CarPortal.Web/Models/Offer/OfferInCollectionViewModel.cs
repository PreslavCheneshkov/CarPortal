namespace CarPortal.Web.Models.Offer;
#pragma warning disable


public class OfferInCollectionViewModel
{
    public int OfferId { get; set; }

    public string OfferName { get; set; }

    public string ThumbnailUrl { get; set; } = null!;

    public string Manufacturer { get; set; }

    public string Model { get; set; }

    public decimal Price { get; set; }

    public int Year { get; set; }

    public int? HorsePower { get; set; }

    public string TransmissionType { get; set; } = null!;

    public string FuelType { get; set; }

    public int Mileage { get; set; }

}
