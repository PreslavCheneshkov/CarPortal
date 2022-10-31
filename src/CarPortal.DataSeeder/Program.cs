using CarPortal.Data;
using CarPortal.Data.Entities.Car;
using CarPortal.Data.Entities.Offer;
#pragma warning disable CS8602 // Rethrow to preserve stack details

namespace CarPortal.DataSeeder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarPortalDbContext context = new CarPortalDbContext();

            

            SeedColors(context);
            SeedExtras(context);
            SeedFuelTypes(context);
            SeedManufacturers(context);
            SeedModels(context);
            SeedTransmissionTypes(context);
            SeedVehicleCategories(context);
            SeedRegions(context);
            SeedCities(context);
        }
        static void SeedColors(CarPortalDbContext context)
        {
            string[] colorStrings = new string[] { "Red", "Blue", "Green", "Black", "White", "Silver", "Grey", "Yellow", "Orange" };

            var colors = new List<Color>();

            foreach (var color in colorStrings)
            {
                colors.Add(new Color() { Name = color });
            }

            context.Colors.AddRange(colors);
            context.SaveChanges();
        }
        static void SeedExtras(CarPortalDbContext context)
        {
            string[] extrasStrings = new string[] { "Leather seats", "LED Headlights", "Cruise Control", "Heated seats", "Navigation", "Sunroof", "Premium sound system", "7 seats", "Fogligths" };

            var extras = new List<Extra>();

            foreach (var extra in extrasStrings)
            {
                extras.Add(new Extra() { Name = extra });
            }

            context.Extras.AddRange(extras);
            context.SaveChanges();
        }
        static void SeedFuelTypes(CarPortalDbContext context)
        {
            string[] fuelTypeStrings = new string[] { "Gasoline", "Diesel", "LPG", "Gasoline Hybrid", "Diesel Hybrid", "EV", "Methane"};

            var fuelTypes = new List<FuelType>();

            foreach (var fuelType in fuelTypeStrings)
            {
                fuelTypes.Add(new FuelType() { Name = fuelType });
            }

            context.FuelTypes.AddRange(fuelTypes);
            context.SaveChanges();
        }
        static void SeedManufacturers(CarPortalDbContext context)
        {
            string[] manufacturersStrings = new string[] { "Volkswagen", "Audi", "Porsche", "BMW", "Mercedes-Benz", "Opel", "Honda", "Toyota", "Subaru", "Volvo", "Citroen", "Peugeot", "Renault", "Fiat", "Alfa Romeo", "Ford", "Dacia", "Seat", "Kia", "Hyundai" };

            var manufacturers = new List<Manufacturer>();

            foreach (var manufacturer in manufacturersStrings)
            {
                manufacturers.Add(new Manufacturer() { Name = manufacturer });
            }

            context.Manufacturers.AddRange(manufacturers);
            context.SaveChanges();
        }
        static void SeedModels(CarPortalDbContext context)
        {
            var manufacturersSQL = context.Manufacturers.Select(m => new
            {
                Id = m.Id,
                Name = m.Name,
            });

            Dictionary<string, int> manufacturers = new Dictionary<string, int>();

            foreach (var manufacturer in manufacturersSQL)
            {
                manufacturers.Add(manufacturer.Name, manufacturer.Id);
            }

            string[] models = new string[] {};

            foreach (var manufacturer in manufacturers)
            {
                switch (manufacturer.Key)
                {
                    case "Volkswagen": models = new string[]  { "Golf", "Passat", "Arteon", "Polo", "Toareg" }; break;
                    case "Audi": models = new string[] { "A3", "A4", "A5", "A6", "A8", "S3", "RS4", "RS6", "R8" }; break;
                    case "Porsche": models = new string[] { "911", "718", "Panamera", "Cayenne", "Macan" }; break;
                    case "BMW": models = new string[] { "3-series", "5-series", "7-series", "X3", "X5", "X1", "M3", "M4", "M5" }; break;
                    case "Mercedes-Benz": models = new string[] { "A-class", "C-class", "E-class", "S-class", "G-class" }; break;
                    case "Opel": models = new string[] { "Astra", "Corsa", "Signum", "Vectra", "Mokka" }; break;
                    case "Honda": models = new string[] { "Civic", "Accord", "Jazz", "CR-V", "HR-V" }; break;
                    case "Toyota": models = new string[] { "Corolla", "Auris", "Yaris", "LandCruiser", "Avensis" }; break;
                    case "Subaru": models = new string[] { "Forester", "Impreza", "Legacy"}; break;
                    case "Volvo": models = new string[] { "V40", "V60", "XC40", "XC60"}; break;
                    case "Citroen": models = new string[] { "C3", "C4", "C5", "C6", "C8" }; break;
                    case "Peugeot": models = new string[] { "306", "406", "307", "407", "408" }; break;
                    case "Renault": models = new string[] { "Clio", "Megane", "Laguna"}; break;
                    case "Fiat": models = new string[] { "Panda", "500"}; break;
                    case "Alfa Romeo": models = new string[] { "156", "147", "159", "GT", "Guillia" }; break;
                    case "Dacia": models = new string[] { "Duster", "Sandero"}; break;
                    case "Seat": models = new string[] { "Ibiza", "Toledo", "Leon", "Ateca"}; break;
                    case "Ford": models = new string[] { "Focus", "Fiesta", "F-150", "Mondeo"}; break;
                    case "Kia": models = new string[] { "Stinger", "Ceed", "Sportage", "Polo", "Toareg" }; break;
                    case "Hyundai": models = new string[] { "Tuscon", "i30", "i20", "i10"}; break;
                    default: break;
                }
                List<Model> modelsToAdd = new List<Model>();
                foreach (var model in models)
                {
                    modelsToAdd.Add(new Model() { ManufacturerId = manufacturer.Value, Name = model });
                }

                context.Models.AddRange(modelsToAdd);
                context.SaveChanges();
            }
        }
        static void SeedTransmissionTypes(CarPortalDbContext context)
        {
            string[] transmissionStrings = new string[] { "Manual 5-speed", "Manual 4-speed", "Manual 6-speed", "Automatic", "Automatic-robot", "Dual-clutch automatic", "CVT"};

            var transmissions = new List<TransmissionType>();

            foreach (var transmission in transmissionStrings)
            {
                transmissions.Add(new TransmissionType() { Name = transmission });
            }

            context.TransmissionTypes.AddRange(transmissions);
            context.SaveChanges();
        }
        static void SeedVehicleCategories(CarPortalDbContext context)
        {
            string[] vehicleCategoriesStrings = new string[] { "Sedan", "Estate", "Small SUV", "Large SUV", "Off-road SUV", "Coupe", "Hatchback" };

            var vehicleCategories = new List<VehicleCategory>();

            foreach (var category in vehicleCategoriesStrings)
            {
                vehicleCategories.Add(new VehicleCategory() { Name = category});
            }

            context.VehicleCategories.AddRange(vehicleCategories);
            context.SaveChanges();
        }
        static void SeedRegions(CarPortalDbContext context)
        {
            string[] regionsStrings = new string[] { "Varna", "Sofia", "Pleven", "Plovdiv", "Burgas", "Veliko Turnovo", "Ruse" };

            var regions = new List<Region>();

            foreach (var region in regionsStrings)
            {
                regions.Add(new Region() { Name = region });
            }

            context.Regions.AddRange(regions);
            context.SaveChanges();
        }
        static void SeedCities(CarPortalDbContext context)
        {
            var regionsSQL = context.Regions.Select(m => new
            {
                Id = m.Id,
                Name = m.Name,
            });

            Dictionary<string, int> regions = new Dictionary<string, int>();

            foreach (var region in regionsSQL)
            {
                regions.Add(region.Name, region.Id);
            }

            string[] cities = new string[] { };

            foreach (var region in regions)
            {
                switch (region.Key)
                {
                    case "Varna": cities = new string[] { "Varna", "Aksakovo", "Devnya", "Provadiya", "Kranevo" }; break;
                    case "Sofia": cities = new string[] { "Sofia", "Pravets"}; break;
                    case "Pleven": cities = new string[] { "Pleven", "Belene", "Nikopol", "Levski" }; break;
                    case "Plovdiv": cities = new string[] { "Plovdiv", "Asenovgrad", "Rakovski" }; break;
                    case "Burgas": cities = new string[] { "Burgas", "Aytos", "Nesebar" }; break;
                    case "Veliko Turnovo": cities = new string[] { "Veliko Turnovo", "Svishtov", "Gorna Oryahovica" }; break;
                    case "Ruse": cities = new string[] { "Ruse", "Byala" }; break;
                    
                    default: break;
                }
                List<City> citiesToAdd = new List<City>();
                foreach (var city in cities)
                {
                    citiesToAdd.Add(new City() { RegionId = region.Value, Name = city });
                }

                context.Cities.AddRange(citiesToAdd);
                context.SaveChanges();
            }
        }
    }
}