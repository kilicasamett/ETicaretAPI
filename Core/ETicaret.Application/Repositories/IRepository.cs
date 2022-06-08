using System;
using ETicaretAPI.Domain.Entity.Common;
using Microsoft.EntityFrameworkCore;
namespace ETicaretAPI.Application.Repositories
{
	public interface IRepository<T> where T : BaseEntity
	{
		DbSet<T> Table { get; } 
	}
	
}

