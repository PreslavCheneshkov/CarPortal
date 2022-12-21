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
    public class OfferEntityConfiguration : IEntityTypeConfiguration<Offer>
    {
        private List<Offer> offers;

        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder
                .HasOne(o => o.City)
                .WithMany(c => c.Offers)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(o => o.Images)
                .WithOne(i => i.Offer)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(o => o.OfferThumbnail)
                .WithOne(t => t.Offer)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(o => o.Comments)
                .WithOne(c => c.Offer)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Property(o => o.OfferThumbnailId).HasDefaultValue("firstSeedThumbnail");

            SeedOffers();
            builder.HasData(offers);
        }

        private void SeedOffers()
        {
            this.offers = new List<Offer>();
            Random random = new Random();

            for (int i = 1; i <= 200; i++)
            {
                offers.Add(new Offer()
                {
                    Id = i,
                    Name = $"SeedOffer #{i}",
                    CarId = i,
                    AdditionalInfo = $"",
                    CreatedOn = DateTime.UtcNow,
                    LastEdited = DateTime.UtcNow,
                    Price = random.Next(600, 40_000),
                    SellerId = i % 2 == 0 ? "1599b271-fc59-4726-a4a1-49e1ecc43b20" : "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                    RegionId = 1,
                    CityId = 1,
                    ContactPhoneNumber = i % 2 == 0 ? "0123123123" : "0789789789",
                    IsActive = true,
                    OfferThumbnailId = null
                });
            }
        }
    }
}
