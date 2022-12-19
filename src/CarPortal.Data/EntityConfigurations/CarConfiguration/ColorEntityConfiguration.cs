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
    public class ColorEntityConfiguration : IEntityTypeConfiguration<Color>
    {
        private Color[] colors;

        public void Configure(EntityTypeBuilder<Color> builder)
        {
            SeedColors();
            builder.HasData(colors);
        }

        private void SeedColors()
        {
            string[] colorStrings = new string[] { "Red", "Blue", "Green", "Black", "White", "Silver", "Grey", "Yellow", "Orange" };

            colors = new Color[colorStrings.Length];

            for (int i = 1; i <= colorStrings.Length; i++)
            {
                colors[i - 1] = new Color()
                {
                    Id = i,
                    Name = colorStrings[i - 1],
                };
            }
        }
    }
}
