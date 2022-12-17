using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.Search
{
    public class SearchModelDto
    {
        public int? VehicleCategoryId { get; set; }

        public int? ManufacturerId { get; set; }

        public int? ModelId { get; set; }

        public double? MinEngineDisplacement { get; set; }

        public double? MaxEngineDisplacement { get; set; }

        public int? MinHorsePower { get; set; }

        public int? MaxHorsePower { get; set; }

        public int? MinYear { get; set; }

        public int? MaxYear { get; set; }

        public int? MaxMileage { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? MaxPrice { get; set; }

        public string? Keyword { get; set; }

        public int[]? ExtraIds { get; set; }

        public int[]? ColorIds { get; set; }

        public int[]? FuelTypeIds { get; set; }

        public int[]? TransmissionTypeIds { get; set; }

        public int[]? RegionIds { get; set; }
    }
}
