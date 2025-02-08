using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN.Entities;
using BerberReservationAPI.DOMAIN.Repositories;
using BerberReservationAPI.PERSISTENCE.ContextClasses;
using Microsoft.EntityFrameworkCore;

namespace BerberReservationAPI.PERSISTENCE.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        readonly BerberDbContext _context;
        protected BaseRepository(BerberDbContext context)
        {
            _context = context; 
        }
        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();  
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T originEntity, T newEntity)
        {
            _context.Set<T>().Entry(originEntity).CurrentValues.SetValues(newEntity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
    }
}
