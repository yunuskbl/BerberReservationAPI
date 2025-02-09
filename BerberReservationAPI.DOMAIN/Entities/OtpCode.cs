using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerberReservationAPI.DOMAIN.Entities
{
    public class OtpCode
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Code { get; set; }  // 6 haneli OTP
        public DateTime ExpirationTime { get; set; }
        public bool IsUsed { get; set; } = false;
    }
}
