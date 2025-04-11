using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int RentalId { get; set; } 
        public Rental Rental { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } 
        public string PaymentMethod { get; set; }
    }
}
