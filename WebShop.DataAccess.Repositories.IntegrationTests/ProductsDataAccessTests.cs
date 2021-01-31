using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using NUnit.Framework;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.Repositories.Interfaces;
using WebShop.DataAccess.Repositories.Repos;

namespace WebShop.DataAccess.Repositories.IntegrationTests
{
    public class ProductsDataAccessTests : BaseSetup
    {
        private IProductDataAccess _dataAccess;

        [SetUp]
        public void Setup()
        {
            _dataAccess = ServiceProvider.GetService<IProductDataAccess>();
            _dataAccess.DeleteProducts();
        }

        [Test]
        public void ICanSaveAndReadProducts()
        {
            //Arrange
            var dto = new ProductDto("Nail", 200, "Super nails");
            //Assign
            _dataAccess.SaveProducts(new List<ProductDto>() { dto });
            //Assert
            var products = _dataAccess.GetProducts();
            Assert.True(products.Any(x => x.Name == dto.Name && x.Price == dto.Price));
        }
    }
}