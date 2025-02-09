using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN;
using BerberReservationAPI.DOMAIN.Repositories;
using BerberReservationAPI.PERSISTENCE.ContextClasses;

namespace BerberReservationAPI.PERSISTENCE.Repositories
{
    public class BerberRepository:BaseRepository<Berber>,IBarberRepository
    {
        public BerberRepository(BerberDbContext context):base(context)
        {
            
        }
    }
}
