using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Commons;

namespace WebShop.DataAccess.ProductDatabaseContext.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public AccessRole AccessRole { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}


