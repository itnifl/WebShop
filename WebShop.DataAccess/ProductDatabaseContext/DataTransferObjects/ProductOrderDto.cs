using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WebShop.DataAccess.ProductDatabaseContext.Entities;

namespace WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects
{
    public class ProductOrderDto
    {
        public ProductOrderDto()
        {

        }
        public ProductOrderDto(List<ProductDto> productsInOrder)
        {
            this.ProductsInOrder = productsInOrder;
        }
        public ProductOrderDto(ProductOrder po)
        {
            this.ProductOrderId = po.ProductOrderId;
            this.Discount = po.Discount;
            ProductsInOrder = new List<ProductDto>();
            foreach (var pio in po.ProductsInOrder)
            {
                ProductsInOrder.Add(new ProductDto(pio.Product));
            }
        }
        public Guid ProductOrderId { get; set; }

        public int Quantity
        {
            get => ProductsInOrder?.Count ?? 0;

        }

        public double TotalPrice
        {
            get => ProductsInOrder?.Sum(x => x.Price) - Discount ?? 0;
        }
        public double Discount { get; set; }
        public List<ProductDto> ProductsInOrder { get; set; }
    }
}
