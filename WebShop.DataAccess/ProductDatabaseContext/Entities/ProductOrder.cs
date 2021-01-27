using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WebShop.DataAccess.ProductDatabaseContext.Entities
{
    public class ProductOrder
    {
        public Guid ProductOrderId { get; set; }

        [NotMapped]
        public int Quantity
        {
            get => ProductsInOrder?.Count ?? 0;

        }

        [NotMapped]
        public double TotalPrice
        {
            get => ProductsInOrder?.Sum(x => x.Product.Price) - Discount ?? 0;
        }
        public double Discount { get; set; }
        public virtual ICollection<ProductOrderProduct> ProductsInOrder { get; set; }
        public virtual Order Order { get; set; }
    }
}
