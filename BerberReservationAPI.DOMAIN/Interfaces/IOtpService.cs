using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerberReservationAPI.DOMAIN.Interfaces
{
    public interface IOtpService
    {
        Task<string> GenerateOtpAsync(string phoneNumber);
        Task<bool> ValidateOtpAsync(string phoneNumber, string code);
    }
}
