﻿using System;
using ETicaretAPI.Domain.Entity.Common;

namespace ETicaretAPI.Domain.Entity
{
	public class Order: BaseEntity
	{
        public Guid  CustomerId { get; set; }
        public string Description { get; set; }
        public string  Adress { get; set; }
        public ICollection <Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}

