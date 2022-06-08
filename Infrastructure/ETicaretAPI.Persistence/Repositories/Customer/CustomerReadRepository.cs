using System;
using ETicaretAPI.Application.Repositories.ICustomer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<ETicaretAPI.Domain.Entity.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}

