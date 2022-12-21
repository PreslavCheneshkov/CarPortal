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
    public class OfferThumbnailEntityConfiguration : IEntityTypeConfiguration<OfferThumbnail>
    {
        private List<OfferThumbnail> thumbnails;

        public void Configure(EntityTypeBuilder<OfferThumbnail> builder)
        {
            builder
                .HasOne(t => t.Offer)
                .WithOne(o => o.OfferThumbnail)
                .OnDelete(DeleteBehavior.Restrict);

            SeedThumbnails();
            builder.HasData(this.thumbnails);
        }

        private void SeedThumbnails()
        {
            thumbnails = new List<OfferThumbnail>
            {
                new OfferThumbnail()
                {
                    Id = "firstSeedThumbnail",
                    Extension = ".jpg"
                },
                new OfferThumbnail()
                {
                    Id = "secondSeedThumbnail",
                    Extension = ".jpg"
                }
            };

        }
    }
}
