using System;
using ETicaretAPI.Application.Repositories.IOrder;
using ETicaretAPI.Domain.Entity;
using ETicaretAPI.Persistence.Contexts;
namespace ETicaretAPI.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}

