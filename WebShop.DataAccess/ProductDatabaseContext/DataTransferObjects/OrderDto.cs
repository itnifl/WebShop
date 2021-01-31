using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.DataAccess.ProductDatabaseContext.Entities;

namespace WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects
{
    public class OrderDto
    {
        public OrderDto()
        {

        }
        public OrderDto(List<ProductOrderDto> productOrders)
        {
            ProductOrders = productOrders;
        }
        public OrderDto(Order order)
        {
            this.OrderId = order.OrderId;
            ProductOrders = new List<ProductOrderDto>();
            foreach (var po in order.ProductOrders)
            {
                ProductOrders.Add(new ProductOrderDto(po));
            }
        }
        public Guid OrderId { get; set; }

        /// <summary>
        /// One order can have many orders of products
        /// </summary>
        public List<ProductOrderDto> ProductOrders { get; set; }
    }
}
