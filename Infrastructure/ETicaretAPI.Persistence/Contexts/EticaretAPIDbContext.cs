using System;
using ETicaretAPI.Domain.Entity;
using ETicaretAPI.Domain.Entity.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Contexts
{
    public class EticaretAPIDbContext : DbContext
    { 
        /// <summary>
        /// Ioc Container will fill except erorr
        /// </summary>
        /// <param name="options"></param>
        public EticaretAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// Entity karşılığında belirtilen formatta tablo olduğunu ve eşleştirilme işleştirmektedir.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public  async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : entityler üzerinden yapılan değişiklik veya eklenen verilerin yakalanmasını sağlamaktadır.

            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
    

}

