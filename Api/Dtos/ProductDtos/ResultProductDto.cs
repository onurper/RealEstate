﻿namespace Api.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public decimal? Price { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public int? ProductCategoryId { get; set; }
    }
}