using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;

namespace WebShop.DataAccess.Repositories.Interfaces
{
    public interface IProductDataAccess
    {
        void DeleteProducts();
        List<ProductDto> GetProducts();
        List<ProductDto> GetProducts(string nameFilter);
        void SaveProducts(List<ProductDto> products);
    }
}
