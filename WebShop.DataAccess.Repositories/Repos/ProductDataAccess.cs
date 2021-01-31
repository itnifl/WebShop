using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.ProductDatabaseContext.Entities;
using WebShop.DataAccess.Repositories.Interfaces;

namespace WebShop.DataAccess.Repositories.Repos
{
    public class ProductDataAccess : IProductDataAccess
    {
        private readonly ILogger<ProductDataAccess> _logger;
        private readonly ProductDatabaseContext.ProductDatabaseContext _dbContext;

        public ProductDataAccess(ProductDatabaseContext.ProductDatabaseContext dbContext, ILogger<ProductDataAccess> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void DeleteProducts()
        {
            _dbContext.Database.ExecuteSqlRaw("delete from Product");
            _dbContext.SaveChanges();
        }

        public List<ProductDto> GetProducts()
        {
            var productList = new List<ProductDto>();

            try
            {
                foreach (var p in _dbContext.Product)
                {
                    productList.Add(new ProductDto(p));
                }
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Oops, something  went wrong: " + e.Message);
                throw;
            }

            return productList;
        }

        public List<ProductDto> GetProducts(string nameFilter)
        {
            var productList = new List<ProductDto>();
            try
            {
                foreach (var p in _dbContext.Product.Where(x => x.Name.Contains(nameFilter)))
                {
                    productList.Add(new ProductDto(p));
                }
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Oops, something  went wrong: " + e.Message);
                throw;
            }


            return productList;
        }

        public void SaveProducts(List<ProductDto> products)
        {
            try
            {
                foreach (var p in products)
                {
                    _dbContext.Product.Add(new Product()
                    {
                        Description = p.Description,
                        Name = p.Name,
                        Price = p.Price
                    });
                }

                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, "Oops, something  went wrong: " + e.Message);
                throw;
            }
        }
    }
}
