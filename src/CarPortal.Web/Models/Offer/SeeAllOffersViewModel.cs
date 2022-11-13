namespace CarPortal.Web.Models.Offer;
#pragma warning disable


public class SeeAllOffersViewModel
{
    public string ImageUrl { get; set; } = null!;
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public int Year { get; set; }
    public string FuelType { get; set; }
    public int Mileage { get; set; }
    public string ContactPhone { get; set; }
}
