using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebShop.DataAccess.ProductDatabaseContext.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public String Description { get; set; }

        public virtual ICollection<ProductOrderProduct> ProductOrders { get; set; }
    }
}