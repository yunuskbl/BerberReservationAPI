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
    public class ServiceRepository:BaseRepository<Service>,IServiceRepository
    {
        public ServiceRepository(BerberDbContext context):base(context)
        {
            
        }
    }
}
