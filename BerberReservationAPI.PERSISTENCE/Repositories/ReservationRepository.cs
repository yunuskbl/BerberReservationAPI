using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN;
using BerberReservationAPI.DOMAIN.Repositories;
using BerberReservationAPI.PERSISTENCE.ContextClasses;

namespace BerberReservationAPI.PERSISTENCE.Repositories
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository    
    {
        public ReservationRepository(BerberDbContext context ):base(context)
        {
            
        }
    }
}
