﻿namespace project_cls.Service_layer.Dto.Product
{
    public class ProductUpdateDto
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

    }
}
