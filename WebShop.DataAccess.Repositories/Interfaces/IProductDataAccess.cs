using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;

namespace WebShop.DataAccess.Repositories.Interfaces
{
    public interface IProductDataAccess
    {
        List<ProductDto> GetProducts();
        void SaveProducts(List<ProductDto> products);
    }
}
