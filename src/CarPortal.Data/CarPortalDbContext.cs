using CarPortal.Data.Entities.Car;
using CarPortal.Data.Entities.News;
using CarPortal.Data.Entities.Offer;
using CarPortal.Data.Entities.User;
using CarPortal.Data.EntityConfigurations;
using CarPortal.Data.EntityConfigurations.CarConfiguration;
using CarPortal.Data.EntityConfigurations.MappingTables;
using CarPortal.Data.EntityConfigurations.NewsArticleConfigurations;
using CarPortal.Data.EntityConfigurations.OfferConfigurations;
using CarPortal.Data.EntityConfigurations.User;
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

        public DbSet<NewsArticle> NewsArticles { get; set; }

        public DbSet<NewsArticleComment> NewsArticleComments { get; set; }
        
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
            //user configs
            new CarPortalUserEntityConfiguration().Configure(builder.Entity<CarPortalUser>());
            new CarPortalProfileEntityConfiguration().Configure(builder.Entity<CarPortalProfile>());

            //mapping table configs
            new ProfileInterestedOffersEntityConfiguration().Configure(builder.Entity<ProfileInterestedOffers>());
            new CarExtraEntityConfiguration().Configure(builder.Entity<CarExtra>());

            // car helper data configs
            new ColorEntityConfiguration().Configure(builder.Entity<Color>());
            new ExtraConfiguration().Configure(builder.Entity<Extra>());
            new FuelTypeEntityConfiguration().Configure(builder.Entity<FuelType>());
            new ManufacturerEntityConfiguration().Configure(builder.Entity<Manufacturer>());
            new VehicleModelEntityConfiguration().Configure(builder.Entity<Model>());
            new TransmissionTypeEntityConfiguration().Configure(builder.Entity<TransmissionType>());
            new VehicleCategoryEntityConfiguration().Configure(builder.Entity<VehicleCategory>());

            // offer helper data configs
            new RegionEntityConfiguration().Configure(builder.Entity<Region>());
            new CityEntityConfiguration().Configure(builder.Entity<City>());

            //car
            new CarEntityConfiguration().Configure(builder.Entity<Car>());
            //carExtras

            //offer
            new OfferEntityConfiguration().Configure(builder.Entity<Offer>());
            //images
            new OfferThumbnailEntityConfiguration().Configure(builder.Entity<OfferThumbnail>());

            //news articles
            new NewsArticleEntityConfiguration().Configure(builder.Entity<NewsArticle>());
            new NewsArticleCommentEntityConfiguration().Configure(builder.Entity<NewsArticleComment>());

            base.OnModelCreating(builder);
        }
    }
}