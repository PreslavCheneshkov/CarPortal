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

            int index = 1;

            for (int i = 1; i <= 20; i++)
            {
                switch (i)
                {
                    case 1: manufacturersModels.Add(i, new string[] { "Golf", "Passat", "Arteon", "Polo" }); break;
                    case 2: manufacturersModels.Add(i, new string[] { "A3", "A4", "A5", "A6" }); break;
                    case 3: manufacturersModels.Add(i, new string[] { "911", "718", "Panamera", "Cayenne" }); break;
                    case 4: manufacturersModels.Add(i, new string[] {"3-series", "5-series", "7-series", "X3" }); break;
                    case 5: manufacturersModels.Add(i, new string[] { "A-class", "C-class", "E-class", "S-class" }); break;
                    case 6: manufacturersModels.Add(i, new string[] { "Astra", "Corsa", "Signum", "Vectra" }); break;
                    case 7: manufacturersModels.Add(i, new string[] { "Civic", "Accord", "Jazz", "CR-V" }); break;
                    case 8: manufacturersModels.Add(i, new string[] { "Corolla", "Auris", "Yaris", "LandCruiser" }); break;
                    case 9: manufacturersModels.Add(i, new string[] { "Forester", "Impreza", "Legacy", "Crosstrek" }); break;
                    case 10: manufacturersModels.Add(i, new string[] { "V40", "V60", "XC40", "XC60" }); break;
                    case 11: manufacturersModels.Add(i, new string[] { "C3", "C4", "C5", "C6" }); break;
                    case 12: manufacturersModels.Add(i, new string[] { "306", "406", "307", "407" }); break;
                    case 13: manufacturersModels.Add(i, new string[] { "Clio", "Megane", "Laguna", "Twingo" }); break;
                    case 14: manufacturersModels.Add(i, new string[] { "Panda", "500", "124", "Albea " }); break;
                    case 15: manufacturersModels.Add(i, new string[] { "156", "147", "159", "GT" }); break;
                    case 16: manufacturersModels.Add(i, new string[] { "Focus", "Fiesta", "F-150", "Mondeo" }); break;
                    case 17: manufacturersModels.Add(i, new string[] { "Duster", "Sandero", "Logan", "Dokker" }); break;
                    case 18: manufacturersModels.Add(i, new string[] { "Ibiza", "Toledo", "Leon", "Ateca" }); break;
                    case 19: manufacturersModels.Add(i, new string[] { "Stinger", "Ceed", "Sportage", "K5" }); break;
                    case 20: manufacturersModels.Add(i, new string[] { "Tuscon", "i30", "i20", "i10" }); break;
                }

                for(int j = 1; j <= manufacturersModels[i].Count(); j++)
                {
                    this.models.Add(new Model()
                    {
                        Id = index,
                        ManufacturerId = i,
                        Name = manufacturersModels[i][j - 1]
                    }) ;
                    index++;
                }
            }
        }
    }
}
