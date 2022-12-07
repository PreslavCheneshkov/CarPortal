using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Car
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(VehicleCategory))]

        public int VehicleCategoryId { get; set; }

        public VehicleCategory VehicleCategory { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Model))]
        public int ModelId { get; set; }

        public Model Model { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Manufacturer))]
        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(FuelType))]
        public int FuelTypeId { get; set; }

        public FuelType FuelType { get; set; } = null!;

        public double? EngineDisplacement { get; set; }

        public int? HorsePower { get; set; }

        [Required]
        [ForeignKey(nameof(TransmissionType))]

        public int TransmissionTypeId { get; set; }

        public TransmissionType TransmissionType { get; set; } = null!;

        public int Year { get; set; }

        public int Mileage { get; set; }

        [Required]
        [ForeignKey(nameof(Color))]
        public int ColorId { get; set; }

        public Color Color { get; set; } = null!;

        public bool IsBrandNew { get; set; }

        public virtual ICollection<CarExtra> Extras { get; set; } = new List<CarExtra>();
    }
}
