﻿namespace Talabat.Entities.entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
