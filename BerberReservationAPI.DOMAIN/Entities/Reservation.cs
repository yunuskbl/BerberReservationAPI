using System.Threading;
using BerberReservationAPI.DOMAIN.Entities;

namespace BerberReservationAPI.DOMAIN
{
    public class Reservation:BaseEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int BerberId { get; set; }
        public Berber? Berber { get; set; }

        public DateTime ReservationDate { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
