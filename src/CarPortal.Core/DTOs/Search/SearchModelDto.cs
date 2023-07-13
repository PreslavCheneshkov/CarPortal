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

        public bool? FromDealer { get; set; }

        public string? OrderBy { get; set; }

        public List<int>? ExtraIds { get; set; } = new List<int>();

        public List<int>? ColorIds { get; set; } = new List<int>();

        public List<int>? FuelTypeIds { get; set; } = new List<int>();

        public List<int>? TransmissionTypeIds { get; set; } = new List<int>();
            
        public List<int>? RegionIds { get; set; } = new List<int>();
    }
}
