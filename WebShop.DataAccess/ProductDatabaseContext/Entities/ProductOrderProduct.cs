using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WebShop.DataAccess.ProductDatabaseContext.Entities
{
    public class ProductOrderProduct
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid ProductOrderId { get; set; }
        public ProductOrder ProductOrder { get; set; }
    }
}
