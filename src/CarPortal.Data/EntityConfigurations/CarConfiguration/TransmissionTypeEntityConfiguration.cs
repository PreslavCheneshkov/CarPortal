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
    public class TransmissionTypeEntityConfiguration : IEntityTypeConfiguration<TransmissionType>
    {
        private TransmissionType[] transmissions;
        public void Configure(EntityTypeBuilder<TransmissionType> builder)
        {
            SeedTransmissionTypes();
            builder.HasData(transmissions);
        }

        private void SeedTransmissionTypes()
        {
            string[] transmissionStrings = new string[] { "Manual 5-speed", "Manual 4-speed", "Manual 6-speed", "Automatic", "Automatic-robot", "Dual-clutch automatic", "CVT" };

            this.transmissions = new TransmissionType[transmissionStrings.Length];

            for (int i = 1; i <= transmissionStrings.Length; i++)
            {
                transmissions[i - 1] = new TransmissionType()
                {
                    Id = i,
                    Name = transmissionStrings[i - 1],
                };
            }
        }
    }
}
