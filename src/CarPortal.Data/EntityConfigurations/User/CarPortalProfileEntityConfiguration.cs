using CarPortal.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.User
{
    public class CarPortalProfileEntityConfiguration : IEntityTypeConfiguration<CarPortalProfile>
    {
        private CarPortalProfile admin;
        private CarPortalProfile newsWriter;
        private CarPortalProfile dealer;
        private CarPortalProfile regular;

        public void Configure(EntityTypeBuilder<CarPortalProfile> builder)
        {
            SeedProfiles();
            builder.HasData(admin, newsWriter, dealer, regular);
        }

        private void SeedProfiles()
        {
            admin = new CarPortalProfile()
            {
                Id = "b477be35-f36e-4986-91a4-2af08b8aace9",
                CarPortalUserId = "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                CreatedDate = DateTime.UtcNow,
                IsDealer = false,
            };

            newsWriter = new CarPortalProfile()
            {
                Id = "840f8101-dba1-4559-af43-a15af74d321c",
                CarPortalUserId = "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                CreatedDate = DateTime.UtcNow,
                IsDealer = false
            };

            dealer = new CarPortalProfile()
            {
                Id = "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                CarPortalUserId = "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                CreatedDate = DateTime.UtcNow,
                IsDealer = true
            };

            regular = new CarPortalProfile()
            {
                Id = "243d758e-59b0-46bd-bc56-3b41c4adc264",
                CarPortalUserId = "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                CreatedDate = DateTime.UtcNow,
                IsDealer = false
            };
        }
    }
}
