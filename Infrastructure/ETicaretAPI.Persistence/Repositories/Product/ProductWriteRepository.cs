using System;
using ETicaretAPI.Application.Repositories.IProduct;
using ETicaretAPI.Domain.Entity;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}

