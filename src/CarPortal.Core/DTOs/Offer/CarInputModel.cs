using CarPortal.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.Offer
{
    public class CarInputModel
    {
        [Required]
        public int VehicleCategoryId { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        public int ModelId { get; set; }

        [Required]
        public int FuelTypeId { get; set; }

        public double? EngineDisplacement { get; set; }

        public int? HorsePower { get; set; }

        [Required]
        public int TransmissionTypeId { get; set; }

        [Required]
        [Year]
        public int Year { get; set; }

        [Required]
        public int Mileage { get; set; }

        [Required]
        public int ColorId { get; set; }

        [Required]
        public bool IsBrandNew { get; set; }

        public List<int> SelectedExtrasIds { get; set; } = new List<int>();
    }
}
