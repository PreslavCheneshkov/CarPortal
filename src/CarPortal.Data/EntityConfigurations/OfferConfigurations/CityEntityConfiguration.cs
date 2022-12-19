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
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        private Dictionary<int, string[]> regionsCities;
        private List<City> cities;

        public void Configure(EntityTypeBuilder<City> builder)
        {
            SeedCities();
            builder
                   .HasOne(c => c.Region)
                   .WithMany(r => r.Cities)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(cities);
        }

        private void SeedCities()
        {
            this.regionsCities = new Dictionary<int, string[]>();
            this.cities = new List<City>();

            for (int i = 1; i <= 7; i++)
            {
                switch (i)
                {
                    case 1: regionsCities.Add(i, new string[] { "Varna", "Aksakovo", "Devnya", "Provadiya", "Kranevo" }); break;
                    case 2: regionsCities.Add(i, new string[] { "Sofia", "Pravets" }); break;
                    case 3: regionsCities.Add(i, new string[] { "Pleven", "Belene", "Nikopol", "Levski" }); break;
                    case 4: regionsCities.Add(i, new string[] { "Plovdiv", "Asenovgrad", "Rakovski" }); break;
                    case 5: regionsCities.Add(i, new string[] { "Burgas", "Aytos", "Nesebar" }); break;
                    case 6: regionsCities.Add(i, new string[] { "Veliko Turnovo", "Svishtov", "Gorna Oryahovica" }); break;
                    case 7: regionsCities.Add(i, new string[] { "Ruse", "Byala", "Tsar Kaloyan" }); break;
                }
                foreach (var city in regionsCities[i])
                {
                    this.cities.Add(new City()
                    {
                        RegionId = i,
                        Name = city,
                    });
                }
            }
        }
    }
}
