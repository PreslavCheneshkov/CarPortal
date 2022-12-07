using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable

namespace CarPortal.Core.DTOs.Offer
{
    public class CarInSingleOfferDto
    {
        public string VehicleCategory { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string FuelType { get; set; }

        public double? EngineDisplacement { get; set; }
        
        public int? HorsePower { get; set; }

        public string TransmissionType { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public IEnumerable<string> Extras { get; set; } = new List<string>();

        public bool IsBrandNew { get; set; }
    }
}
