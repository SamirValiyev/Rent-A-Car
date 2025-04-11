using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; } 
        public int Year { get; set; } 
        public decimal DailyRate { get; set; }
        public string LicensePlate { get; set; } 

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Rental> Rentals { get; set; } 
    }
}
