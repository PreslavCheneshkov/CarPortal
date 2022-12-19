using CarPortal.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.CarConfiguration
{
    public class VehicleModelEntityConfiguration : IEntityTypeConfiguration<Model>
    {
        private Dictionary<int, string[]> manufacturersModels;
        private List<Model> models;

        public void Configure(EntityTypeBuilder<Model> builder)
        {
            SeedModel();
            builder.HasData(models);
        }

        private void SeedModel()
        {
            this.manufacturersModels= new Dictionary<int, string[]>();
            this.models = new List<Model>();

            for (int i = 1; i <= 20; i++)
            {
                switch (i)
                {
                    case 1: manufacturersModels.Add(i, new string[] { "Golf", "Passat", "Arteon", "Polo", "Toareg" }); break;
                    case 2: manufacturersModels.Add(i, new string[] { "A3", "A4", "A5", "A6", "A8", "S3", "RS4", "RS6", "R8" }); break;
                    case 3: manufacturersModels.Add(i, new string[] { "911", "718", "Panamera", "Cayenne", "Macan" }); break;
                    case 4: manufacturersModels.Add(i, new string[] { "3-series", "5-series", "7-series", "X3", "X5", "X1", "M3", "M4", "M5" }); break;
                    case 5: manufacturersModels.Add(i, new string[] { "A-class", "C-class", "E-class", "S-class", "G-class" }); break;
                    case 6: manufacturersModels.Add(i, new string[] { "Astra", "Corsa", "Signum", "Vectra", "Mokka" }); break;
                    case 7: manufacturersModels.Add(i, new string[] { "Civic", "Accord", "Jazz", "CR-V", "HR-V" }); break;
                    case 8: manufacturersModels.Add(i, new string[] { "Corolla", "Auris", "Yaris", "LandCruiser", "Avensis" }); break;
                    case 9: manufacturersModels.Add(i, new string[] { "Forester", "Impreza", "Legacy" }); break;
                    case 10: manufacturersModels.Add(i, new string[] { "V40", "V60", "XC40", "XC60" }); break;
                    case 11: manufacturersModels.Add(i, new string[] { "C3", "C4", "C5", "C6", "C8" }); break;
                    case 12: manufacturersModels.Add(i, new string[] { "306", "406", "307", "407", "408" }); break;
                    case 13: manufacturersModels.Add(i, new string[] { "Clio", "Megane", "Laguna" }); break;
                    case 14: manufacturersModels.Add(i, new string[] { "Panda", "500" }); break;
                    case 15: manufacturersModels.Add(i, new string[] { "156", "147", "159", "GT", "Guillia" }); break;
                    case 16: manufacturersModels.Add(i, new string[] { "Duster", "Sandero" }); break;
                    case 17: manufacturersModels.Add(i, new string[] { "Ibiza", "Toledo", "Leon", "Ateca" }); break;
                    case 18: manufacturersModels.Add(i, new string[] { "Focus", "Fiesta", "F-150", "Mondeo" }); break;
                    case 19: manufacturersModels.Add(i, new string[] { "Stinger", "Ceed", "Sportage"}); break;
                    case 20: manufacturersModels.Add(i, new string[] { "Tuscon", "i30", "i20", "i10" }); break;
                }

                foreach (var model in manufacturersModels[i])
                {
                    this.models.Add(new Model()
                    {
                        ManufacturerId = i,
                        Name = model
                    });
                }
            }
        }
    }
}
