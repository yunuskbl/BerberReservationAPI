using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerberReservationAPI.DOMAIN.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }  // OTP ile giriş için telefon numarası
        public string Name { get; set; }
        public string Role { get; set; }  // "Customer" veya "Barber"
        public bool IsActive { get; set; } = true;
        public virtual Customer? Customer { get; set; }
        public virtual Berber? Berber { get; set; }
    }
}
