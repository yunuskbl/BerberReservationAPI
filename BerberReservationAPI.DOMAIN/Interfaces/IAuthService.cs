using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerberReservationAPI.DOMAIN.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginWithOtpAsync(string phoneNumber, string code);
    }
}
