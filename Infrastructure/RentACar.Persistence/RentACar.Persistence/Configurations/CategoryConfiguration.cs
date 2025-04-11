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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category[]
            {
                new Category
                {
                    Id=1,
                    Name="Sedan",
                },
                new Category
                {
                    Id=2,
                    Name="SUV"
                }
            });
            builder.Property(x => x.Name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.HasKey(x => x.Id);
                          
        }
    }
}
