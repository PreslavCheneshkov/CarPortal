using CarPortal.Data.Entities.Car;
using CarPortal.Data.Entities.Offer;
using CarPortal.Data.Entities.User;
using CarPortal.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace CarPortal.Data
{
    public class CarPortalDbContext : IdentityDbContext<CarPortalUser>
    {
        public CarPortalDbContext() : base()
        {
        }

        public CarPortalDbContext(DbContextOptions<CarPortalDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ProfileInterestedOffers> ProfilesInterestedOffers { get; set; }

        public DbSet<CarPortalProfile> Profiles { get; set; }

        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Color> Colors { get; set; } = null!;

        public DbSet<CarExtra> CarsExtras { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; } = null!;

        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;

        public DbSet<Model> Models { get; set; } = null!;

        public DbSet<TransmissionType> TransmissionTypes { get; set; } = null!;

        public DbSet<VehicleCategory> VehicleCategories { get; set; } = null!;

        public DbSet<Extra> Extras { get; set; } = null!;

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<Offer> Offers { get; set; } = null!;

        public DbSet<Region> Regions { get; set; } = null!;

        public DbSet<OfferComment> OfferComments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new CarPortalUserEntityConfiguration().Configure(builder.Entity<CarPortalUser>());


            builder.Entity<Car>()
                .HasOne(c => c.Manufacturer)
                .WithMany(c => c.Cars)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Offer>()
                .HasOne(o => o.City)
                .WithMany(c => c.Offers)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<City>()
                .HasOne(c => c.Region)
                .WithMany(r => r.Cities)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Offer>()
                .HasMany(o => o.Images)
                .WithOne(i => i.Offer)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Offer>()
                .HasOne(o => o.OfferThumbnail)
                .WithOne(ot => ot.Offer)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<CarExtra>()
                .HasKey(ce => new { ce.CarId, ce.ExtraId });

            base.OnModelCreating(builder);
        }
    }
}