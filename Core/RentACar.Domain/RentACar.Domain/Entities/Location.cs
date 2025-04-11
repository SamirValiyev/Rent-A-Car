using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Address { get; set; } 

        public ICollection<Car> Cars { get; set; }
    }
}
