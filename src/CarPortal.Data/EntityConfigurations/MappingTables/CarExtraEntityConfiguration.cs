using CarPortal.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.MappingTables
{
    public class CarExtraEntityConfiguration : IEntityTypeConfiguration<CarExtra>
    {
        public void Configure(EntityTypeBuilder<CarExtra> builder)
        {
            builder.HasKey(ce => new { ce.CarId, ce.ExtraId });
        }
    }
}
