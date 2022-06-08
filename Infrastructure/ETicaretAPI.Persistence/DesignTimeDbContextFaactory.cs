using System;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFaactory : IDesignTimeDbContextFactory<EticaretAPIDbContext>
    {
        EticaretAPIDbContext IDesignTimeDbContextFactory<EticaretAPIDbContext>.CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EticaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("User ID=postgres;Password=ask97ask;Host=localhost;Port=5432;Database=ETicaretAPIDb;");
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

