

using BerberReservationAPI.DOMAIN.Entities;

namespace BerberReservationAPI.DOMAIN
{
    public class Berber: BaseEntity
    {
        public int BerberId  { get; set; }
        public string? BerberName  { get; set; }
        public string? BerberSurname  { get; set; }
        public string? PhoneNumber{ get; set; }
        public DateTime WorkHours { get; set; }
        public AppUser User { get; set; }   

        public virtual List<Service> Services { get; set; } 
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}