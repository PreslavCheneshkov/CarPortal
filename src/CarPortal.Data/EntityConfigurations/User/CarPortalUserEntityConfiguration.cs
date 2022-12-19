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
