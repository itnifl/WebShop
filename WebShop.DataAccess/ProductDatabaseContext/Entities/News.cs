using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.DataAccess.ProductDatabaseContext.Entities
{
    public class News
    {
        public Guid NewsId { get; set; }

        public string Header { get; set; }
        public string Article { get; set; }
    }
}
