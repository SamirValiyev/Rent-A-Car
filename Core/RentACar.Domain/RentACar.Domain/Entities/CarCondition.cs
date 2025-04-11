using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class CarCondition
    {
        public int Id { get; set; }
        public int CarId { get; set; } 
        public Car Car { get; set; }

        public string ConditionDescription { get; set; } 
        public DateTime RecordedDate { get; set; } 
    }
}
