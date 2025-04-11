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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(new Car[]
            {
                new Car
                {
                    Id=1,
                    Model="CLS63",
                    Make="Mercedes",
                    Year=2019,
                    DailyRate=120,
                    LicensePlate="57-SS-057",
                    CategoryId=1
                },
                new Car
                {
                    Id=2,
                    Model="Range Rover",
                    Make="Land Rover",
                    Year=2020,
                    DailyRate=200,
                    LicensePlate="57-SV-057",
                    CategoryId=2

                }
            });
            builder.Property(x => x.Model)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(x => x.Model)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(x => x.Year)
                   .IsRequired();

            builder.Property(x=>x.LicensePlate)
                   .HasMaxLength(20)
                   .IsRequired();

            //Category
            builder.HasOne(x=>x.Category)
                   .WithMany(x=>x.Cars)
                   .HasForeignKey(x=>x.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
