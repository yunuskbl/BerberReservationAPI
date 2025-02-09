using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN.Entities;
using BerberReservationAPI.DOMAIN.Interfaces;
using BerberReservationAPI.PERSISTENCE.ContextClasses;
using Microsoft.EntityFrameworkCore;

namespace BerberReservationAPI.APPLICATION.Managers
{
    public class OtpService:IOtpService
    {
        private readonly BerberDbContext _context;
        private readonly Random _random = new Random();

        public OtpService(BerberDbContext context)
        {
            _context = context;
        }

        public async Task<string> GenerateOtpAsync(string phoneNumber)
        {
            string otp = _random.Next(100000, 999999).ToString();
            var otpCode = new OtpCode
            {
                PhoneNumber = phoneNumber,
                Code = otp,
                ExpirationTime = DateTime.UtcNow.AddMinutes(1),
                IsUsed = false
            };

            _context.OtpCodes.Add(otpCode);
            await _context.SaveChangesAsync();
            return otp;
        }

        public async Task<bool> ValidateOtpAsync(string phoneNumber, string code)
        {
            var otpCode = await _context.OtpCodes
                .Where(o => o.PhoneNumber == phoneNumber && o.Code == code && o.ExpirationTime > DateTime.UtcNow && !o.IsUsed)
                .FirstOrDefaultAsync();

            if (otpCode == null)
                return false;

            otpCode.IsUsed = true;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
