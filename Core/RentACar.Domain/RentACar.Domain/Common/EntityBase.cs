﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int Id { get ; set; }
        public DateTime CreatedDate { get; set; }=DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; }=DateTime.UtcNow;
        public bool IsDeleted { get;set; }=false;
    }
}
