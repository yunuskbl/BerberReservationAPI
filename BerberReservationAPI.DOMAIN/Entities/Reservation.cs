using BerberReservationAPI.DOMAIN.Entities;

namespace BerberReservationAPI.DOMAIN
{
    public class Reservation:BaseEntity
    {
        public int ReservationID { get; set; }
        public DateTime DateTime { get; set; }
        public string ServiceName { get; set; } = "Saç Sakal Tıraşı";
        
        public virtual Customer? Customer { get; set; }

        public virtual Barber? Barber { get; set; }
        public virtual Service? Service { get; set; }
    }
}
