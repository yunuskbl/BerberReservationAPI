using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerberReservationAPI.DOMAIN.Entities
{
    public class Customer:BaseEntity
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public AppUser User { get; set; }

        public virtual ICollection<Reservation>? Reservations { get; set; }  
    }
}
