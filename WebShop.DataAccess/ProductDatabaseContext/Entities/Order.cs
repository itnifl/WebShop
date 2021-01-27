using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.DataAccess.ProductDatabaseContext.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }

        /// <summary>
        /// One order can have many orders of products
        /// </summary>
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual User User { get; set; }
    }
}
