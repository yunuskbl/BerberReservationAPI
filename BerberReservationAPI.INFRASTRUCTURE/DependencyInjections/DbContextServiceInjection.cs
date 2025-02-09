using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.PERSISTENCE.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BerberReservationAPI.INFRASTRUCTURE.DependencyInjections
{
    public static class DbContextServiceInjection
    {
        public static void AddDbContextServices(this IServiceCollection services)
        {
            ServiceProvider provice = services.BuildServiceProvider();
            IConfiguration configuration = provice.GetService<IConfiguration>();

            services.AddDbContext<BerberDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MyConnectionString")).UseLazyLoadingProxies());

        }
    }
}
