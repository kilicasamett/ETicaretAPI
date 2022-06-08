using System;
using ETicaretAPI.Application.Repositories.IOrder;
using ETicaretAPI.Domain.Entity;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}

