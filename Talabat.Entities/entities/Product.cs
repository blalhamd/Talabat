﻿namespace Talabat.Entities.entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PictureUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; } = null!;

    }
}
