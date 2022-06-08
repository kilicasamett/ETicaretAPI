using System;
using ETicaretAPI.Domain.Entity.Common;

namespace ETicaretAPI.Domain.Entity
{
	public class Product :BaseEntity
	{
        public string Name { get; set; }
        public int Stok { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

