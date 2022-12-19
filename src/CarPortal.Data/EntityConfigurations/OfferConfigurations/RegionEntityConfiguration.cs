using CarPortal.Data.Entities.Offer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.OfferConfigurations
{
    public class RegionEntityConfiguration : IEntityTypeConfiguration<Region>
    {
        private Region[] regions;

        public void Configure(EntityTypeBuilder<Region> builder)
        {
            SeedRegions();
            builder.HasData(regions);
        }

        private void SeedRegions()
        {
            string[] regionsStrings = new string[] { "Varna", "Sofia", "Pleven", "Plovdiv", "Burgas", "Veliko Turnovo", "Ruse" };

            regions = new Region[regionsStrings.Length];

            for (int i = 1; i <= regionsStrings.Length; i++)
            {
                regions[i - 1] = new Region()
                {
                    Id = i,
                    Name = regionsStrings[i - 1],
                };
            }
        }
    }
}
