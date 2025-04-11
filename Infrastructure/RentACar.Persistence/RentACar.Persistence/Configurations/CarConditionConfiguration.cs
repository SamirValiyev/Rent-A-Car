using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Configurations
{
    public class CarConditionConfiguration : IEntityTypeConfiguration<CarCondition>
    {
        public void Configure(EntityTypeBuilder<CarCondition> builder)
        {
            builder.HasData(new CarCondition[]
            {
                new CarCondition
                {
                    Id=1,
                    CarId=1,
                    ConditionDescription="Vuruqlu",
                    RecordedDate=DateTime.UtcNow,
                },
                new CarCondition
                {
                    Id=2,
                    CarId = 2,
                    ConditionDescription="Vuruqsuz",
                    RecordedDate = DateTime.UtcNow
                }
            });
            builder.HasKey(x => x.Id);
           
            builder.Property(x=>x.ConditionDescription)
                   .HasMaxLength(50)
                   .IsRequired();
              
            builder.HasOne(x=>x.Car)
                   .WithMany()
                   .HasForeignKey(x=>x.CarId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
