using System;
using ETicaretAPI.Domain.Entity;
using ETicaretAPI.Domain.Entity.Common;

namespace ETicaretAPI.Domain.Entity
{
	public class Customer:BaseEntity
	{
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    } 
}

