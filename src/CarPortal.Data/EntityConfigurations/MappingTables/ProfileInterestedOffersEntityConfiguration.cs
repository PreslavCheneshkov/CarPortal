using CarPortal.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.MappingTables
{
    public class ProfileInterestedOffersEntityConfiguration : IEntityTypeConfiguration<ProfileInterestedOffers>
    {
        public void Configure(EntityTypeBuilder<ProfileInterestedOffers> builder)
        {
            builder
                .HasOne(po => po.Offer)
                .WithMany(o => o.UsersInterested)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(po => po.CarPortalProfile)
                .WithMany(p => p.SavedOffers)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasKey(po => new { po.CarPortalProfileId, po.OfferId });
        }
    }
}
