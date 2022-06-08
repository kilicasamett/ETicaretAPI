using System;
using ETicaretAPI.Application.Repositories.IProduct;
using ETicaretAPI.Domain.Entity;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}

