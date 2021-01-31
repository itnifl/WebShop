using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.Repositories.Interfaces;
using WebShop.DataAccess.Repositories.Repos;

namespace WebShop.DataAccess.Repositories.IntegrationTests
{
    public class OrdersDataAccessTests : BaseSetup
    {
        private IOrderDataAccess _orderDataAccess;
        private IProductDataAccess _productDataAccess;
        [SetUp]
        public void Setup()
        {
            _orderDataAccess = new OrderDataAccess(); //Preferably get from container
        }

        [Test]
        public void ICanSaveAndReadOrders()
        {
            //Arrange
            var productDto = new ProductDto("Hammer", 100, "Nice hammer");
            _productDataAccess.SaveProducts(new List<ProductDto> { productDto });
            var dto = new OrderDto(new List<ProductOrderDto>() { new ProductOrderDto(new List<ProductDto>() { productDto }) });

            //Assign
            _orderDataAccess.SaveOrders(new List<OrderDto>()
            {
                dto
            });

            //Assert
            var all = _orderDataAccess.GetOrders();
            var allOrderedProducts = all.SelectMany(x => x.ProductOrders.SelectMany(x => x.ProductsInOrder));
            Assert.True(allOrderedProducts.Any(x => x.Name == productDto.Name && x.Price == productDto.Price));
        }
    }
}