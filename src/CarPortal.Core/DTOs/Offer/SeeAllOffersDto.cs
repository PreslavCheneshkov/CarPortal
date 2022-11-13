using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace CarPortal.Core.DTOs.Offer
{
    public class SeeAllOffersDto
    {
        public string ImageUrl { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        public int Mileage { get; set; }
        public string ContactPhone { get; set; }
    }
}
