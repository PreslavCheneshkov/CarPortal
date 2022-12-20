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
    public class OfferCommentEntityConfiguration : IEntityTypeConfiguration<OfferComment>
    {
        public void Configure(EntityTypeBuilder<OfferComment> builder)
        {
            builder
                .HasOne(c => c.CarPortalProfile)
                .WithMany(a => a.OfferComments)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Offer)
                .WithMany(o => o.Comments)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(c => c.IsActive)
                .HasDefaultValue(true);
        }
    }
}
