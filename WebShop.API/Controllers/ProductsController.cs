using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShop.DataAccess.ProductDatabaseContext;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;

namespace WebShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly ProductDatabaseContext _dbContext;

        public ProductsController(ProductDatabaseContext dbContext, ILogger<ProductsController> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get()
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
            }
            return productList;
        }
    }
}
