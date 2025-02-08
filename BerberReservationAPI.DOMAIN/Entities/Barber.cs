

using BerberReservationAPI.DOMAIN.Entities;

namespace BerberReservationAPI.DOMAIN
{
    public class Barber: BaseEntity
    {
        public int BarberId  { get; set; }
        public string? BarberName  { get; set; }
        public string? BarberSurname  { get; set; }
        public string? PhoneNumber{ get; set; }
        public DateTime WorkHours { get; set; }

        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}