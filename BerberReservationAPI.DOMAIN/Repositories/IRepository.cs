using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BerberReservationAPI.DOMAIN.Entities;

namespace BerberReservationAPI.DOMAIN.Repositories
{
    public interface IRepository<T> where T : class,IEntity
    {
        Task<List<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T originEntity, T newEntity);
        Task DeleteAsync(T entity);
    }
    
}
