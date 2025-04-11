using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Common
{
    public interface IEntityBase
    {
         int Id { get; set; }
         DateTime CreatedDate { get; set; }
         DateTime UpdatedDate { get; set; }
         bool IsDeleted { get; set; }
    }
}
