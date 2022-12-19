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
    public class ManufacturerEntityConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        private Manufacturer[] manufacturers;

        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            SeedManufacturers();
            builder.HasData(manufacturers);
        }

        private void SeedManufacturers()
        {
            string[] manufacturersStrings = new string[] { "Volkswagen", "Audi", "Porsche", "BMW", "Mercedes-Benz", "Opel", "Honda", "Toyota", "Subaru", "Volvo", "Citroen", "Peugeot", "Renault", "Fiat", "Alfa Romeo", "Ford", "Dacia", "Seat", "Kia", "Hyundai" };

            this.manufacturers = new Manufacturer[manufacturersStrings.Length];

            for (int i = 1; i <= manufacturersStrings.Length; i++)
            {
                manufacturers[i - 1] = new Manufacturer()
                {
                    Id = i,
                    Name = manufacturersStrings[i - 1],
                };
            }
        }
    }
}
