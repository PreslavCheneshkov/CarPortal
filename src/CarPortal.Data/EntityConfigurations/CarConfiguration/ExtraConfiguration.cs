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
    public class ExtraConfiguration : IEntityTypeConfiguration<Extra>
    {
        private Extra[] extras;
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            SeedExtras();
            builder.HasData(extras);
        }

        private void SeedExtras()
        {
            string[] extrasStrings = new string[] { "Leather seats", "LED Headlights", "Cruise Control", "Heated seats", "Navigation", "Sunroof", "Premium sound system", "7 seats", "Fogligths" };

            extras = new Extra[extrasStrings.Length];

            for (int i = 1; i <= extrasStrings.Length; i++)
            {
                extras[i - 1] = new Extra()
                {
                    Id = i,
                    Name = extrasStrings[i - 1],
                };
            }
        }
    }
}
