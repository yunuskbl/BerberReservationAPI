using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN.Entities;
using BerberReservationAPI.DOMAIN.Repositories;
using BerberReservationAPI.PERSISTENCE.ContextClasses;

namespace BerberReservationAPI.PERSISTENCE.Repositories
{
    public class CustomerRepository:BaseRepository<Customer>,ICustomerRepository
    {
        public CustomerRepository(BerberDbContext context):base(context)
        {
                
        }
    }
}
