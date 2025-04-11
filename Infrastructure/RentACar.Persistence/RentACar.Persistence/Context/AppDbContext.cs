using Microsoft.EntityFrameworkCore;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
              
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarCondition> CarCondition { get; set; }
        public DbSet<CarImage> CarImage { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<User> User { get; set; }

    }
}
