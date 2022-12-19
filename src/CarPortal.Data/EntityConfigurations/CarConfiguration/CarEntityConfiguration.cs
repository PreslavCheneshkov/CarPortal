using CarPortal.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.CarConfiguration
{
    public class CarEntityConfiguration : IEntityTypeConfiguration<Car>
    {
        private List<Car> cars;

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            SeedCars();

            builder
                   .HasOne(c => c.Manufacturer)
                   .WithMany(c => c.Cars)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(this.cars);
        }

        private void SeedCars()
        {
            Random random = new Random();
            this.cars = new List<Car>();

            for (int i = 1; i <= 200; i++)
            {
                int manufacturerId = random.Next(1, 20);
                cars.Add(new Car()
                {
                    Id = i,
                    ManufacturerId = manufacturerId,
                    ModelId = random.Next(((manufacturerId * 4) - 3), (manufacturerId * 4)),
                    FuelTypeId = random.Next(1, 7),
                    TransmissionTypeId = random.Next(1, 7),
                    EngineDisplacement = random.Next(1_000, 4_000),
                    Mileage = random.Next(20_000, 500_000),
                    VehicleCategoryId = random.Next(1, 7),
                    Year = random.Next(1990, DateTime.UtcNow.Year),
                    HorsePower = random.Next(60, 500),
                    ColorId = random.Next(1, 9),
                    IsBrandNew = false,
                });
            }
        }
    }
}
