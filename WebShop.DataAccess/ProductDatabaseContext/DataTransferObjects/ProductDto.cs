using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.DataAccess.ProductDatabaseContext.Entities;


namespace WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects
{
    public class ProductDto
    {
        public ProductDto(Product product)
        {
            this.ProductId = product.ProductId;
            this.Name = product.Name;
            this.Price = product.Price;
            this.Description = product.Description;
        }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public String Description { get; set; }
    }
}