using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN;
using BerberReservationAPI.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BerberReservationAPI.PERSISTENCE.ContextClasses
{
    public class BerberDbContext : DbContext
    {
        public BerberDbContext(DbContextOptions<BerberDbContext> dbContext)
        {
        }
        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
