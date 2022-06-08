using System;
using ETicaretAPI.Application.Repositories.ICustomer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<ETicaretAPI.Domain.Entity.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}

