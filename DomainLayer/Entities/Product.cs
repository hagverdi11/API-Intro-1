﻿using DomainLayer.Common;
namespace DomainLayer.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public Decimal Price { get; set; }

    }
}
