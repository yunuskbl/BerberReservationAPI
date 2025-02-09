using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN.Interfaces;
using BerberReservationAPI.PERSISTENCE.ContextClasses;
using Microsoft.EntityFrameworkCore;

namespace BerberReservationAPI.APPLICATION.Managers
{
    public class AuthService:IAuthService
    {
        private readonly BerberDbContext _dbContext;
        private readonly IOtpService _service;

        public AuthService(IOtpService service, BerberDbContext dbContext)
        {
            _service = service;
            _dbContext = dbContext;
        }
        public async Task<string> LoginWithOtpAsync(string phoneNumber, string code)
        {
            bool isValidOtp = await _service.ValidateOtpAsync(phoneNumber, code);
            if (!isValidOtp)
                return "Geçersiz OTP kodu.";

            var user = await _dbContext.AppUsers.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            if (user == null)
                return "Kullanıcı bulunamadı.";

            return $"Giriş başarılı: {user.Role}";
        }
    }
}
