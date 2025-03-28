﻿namespace TucGolfklubb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
