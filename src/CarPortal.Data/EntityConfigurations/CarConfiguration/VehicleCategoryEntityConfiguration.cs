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
    public class VehicleCategoryEntityConfiguration : IEntityTypeConfiguration<VehicleCategory>
    {
        private VehicleCategory[] categories;

        public void Configure(EntityTypeBuilder<VehicleCategory> builder)
        {
            SeedCategories();
            builder.HasData(categories);
        }

        private void SeedCategories()
        {
            string[] vehicleCategoriesStrings = new string[] { "Sedan", "Estate", "Small SUV", "Large SUV", "Off-road SUV", "Coupe", "Hatchback" };

            this.categories = new VehicleCategory[vehicleCategoriesStrings.Length];

            for (int i = 1; i <= vehicleCategoriesStrings.Length; i++)
            {
                categories[i - 1] = new VehicleCategory()
                {
                    Id = i,
                    Name = vehicleCategoriesStrings[i - 1],
                };
            }
        }
    }
}
