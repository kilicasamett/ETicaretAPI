using System;
using ETicaretAPI.Domain.Entity.Common;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
/// <summary>
/// Ef tracking yapıldı tracking optimizasyonu
/// eğer tracing true ise datayı çağırdığımız db context üzerinden wrrite yapabiliriz
/// scope read için ayara kalkan context'e istinaden  write yaparız fakat tracing kapalı ise yapamayız.
/// </summary>
namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly EticaretAPIDbContext _context;
        public ReadRepository(EticaretAPIDbContext context)
        {
            _context = context;
        }
        public Microsoft.EntityFrameworkCore.DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        } 

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id)); //marker design pattern
            //=> Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            //=> await Table.FindAsync(Guid.Parse(id));
        }
 

        public async Task<T> GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> method, bool tracking = true)
        {
            //=> await Table.FirstOrDefaultAsync(method);
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }
       

        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> method, bool tracking = true)
        {
            //=> Table.Where(method);
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query.Where(method);
        }

    }
}

