using CarPortal.Data.Entities.Car;
using CarPortal.Data.Entities.Offer;
using CarPortal.Data.Entities.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=CarPortal;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;
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
            builder.Entity<Offer>()
                .HasOne(o => o.Seller)
                .WithMany(s => s.PublishedOffers)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Offer>()
                .HasOne(o => o.City)
                .WithMany(c => c.Offers)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<City>()
                .HasOne(c => c.Region)
                .WithMany(r => r.Cities)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}