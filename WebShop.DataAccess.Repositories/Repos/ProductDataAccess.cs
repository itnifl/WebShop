using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.Repositories.Interfaces;

namespace WebShop.DataAccess.Repositories.Repos
{
    public class ProductDataAccess : IProductDataAccess
    {
        public List<ProductDto> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void SaveProducts(List<ProductDto> products)
        {
            throw new NotImplementedException();
        }
    }
}
