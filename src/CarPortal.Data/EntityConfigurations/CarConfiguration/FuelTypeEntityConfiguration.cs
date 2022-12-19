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
    public class FuelTypeEntityConfiguration : IEntityTypeConfiguration<FuelType>
    {
        private FuelType[] fuelTypes;

        public void Configure(EntityTypeBuilder<FuelType> builder)
        {
            SeedFuelTypes();
            builder.HasData(fuelTypes);
        }

        private void SeedFuelTypes()
        {
            string[] fuelTypeStrings = new string[] { "Gasoline", "Diesel", "LPG", "Gasoline Hybrid", "EV", "Methane" };

            this.fuelTypes = new FuelType[fuelTypeStrings.Length];

            for (int i = 1; i <= fuelTypeStrings.Length; i++)
            {
                this.fuelTypes[i - 1] = new FuelType()
                {
                    Id = i,
                    Name = fuelTypeStrings[i - 1]
                };
            }
        }
    }
}
