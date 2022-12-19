using CarPortal.Data.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.User
{
    public class CarPortalUserEntityConfiguration : IEntityTypeConfiguration<CarPortalUser>
    {
        private CarPortalUser admin;
        private CarPortalUser newsWriter;
        private CarPortalUser dealer;
        private CarPortalUser regular;

        public void Configure(EntityTypeBuilder<CarPortalUser> builder)
        {
            SeedUsers();

            builder.HasData(admin, newsWriter, dealer, regular);
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<CarPortalUser>();

            admin = new CarPortalUser()
            {
                Id = "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                ProfileId = "b477be35-f36e-4986-91a4-2af08b8aace9",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@carportal.com",
                NormalizedEmail = "ADMIN@CARPORTAL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 10,
            };

            admin.PasswordHash = hasher.HashPassword(admin, "asdasd123");

            newsWriter = new CarPortalUser()
            {
                Id = "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                ProfileId = "840f8101-dba1-4559-af43-a15af74d321c",
                UserName = "newsWriter",
                NormalizedUserName = "NEWSWRITER",
                Email = "newsWriter@carportal.com",
                NormalizedEmail = "NEWSWRITER@CARPORTAL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 10,
            };

            newsWriter.PasswordHash = hasher.HashPassword(newsWriter, "asdasd123");

            dealer = new CarPortalUser()
            {
                Id = "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                ProfileId = "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                UserName = "dealer",
                NormalizedUserName = "DEALER",
                Email = "dealer@carportal.com",
                NormalizedEmail = "DEALER@CARPORTAL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 10,
            };

            dealer.PasswordHash = hasher.HashPassword(dealer, "asdasd123");

            regular = new CarPortalUser()
            {
                Id = "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                ProfileId = "243d758e-59b0-46bd-bc56-3b41c4adc264",
                UserName = "regular",
                NormalizedUserName = "REGULAR",
                Email = "regular@carportal.com",
                NormalizedEmail = "REGULAR@CARPORTAL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 10,
            };

            regular.PasswordHash = hasher.HashPassword(regular, "asdasd123");
        }
    }
}
