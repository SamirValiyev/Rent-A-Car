using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection collection,IConfiguration configuration)
        {
            collection.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("ConStr")));

        }
    }
}
