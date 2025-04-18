﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; } 
        public Car Car { get; set; }

        public string ImageUrl { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
