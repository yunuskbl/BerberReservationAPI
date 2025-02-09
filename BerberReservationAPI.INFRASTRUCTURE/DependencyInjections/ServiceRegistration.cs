using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.APPLICATION.Managers;
using BerberReservationAPI.DOMAIN.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BerberReservationAPI.INFRASTRUCTURE.DependencyInjections
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IOtpService, OtpService>();
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
