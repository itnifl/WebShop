using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShop.Commons.Extensions;
using WebShop.DataAccess.ProductDatabaseContext;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.ProductDatabaseContext.Entities;
using WebShop.DataAccess.Repositories.Interfaces;

namespace WebShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductDataAccess _dataAccess;

        public ProductsController(IProductDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get(string nameFilter, int? itemsPerPage, int? getPage)
        {
            List<ProductDto> products = null;
            if (nameFilter.IsNullOrEmpty())
            {
                products = _dataAccess.GetProducts();
            }
            else
            {
                products = _dataAccess.GetProducts(nameFilter);
            }

            if (itemsPerPage.HasValue && getPage.HasValue)
            {
                //Would be better to do this via db query or dbContext query, but just for presenting the general idea:
                return products.Skip(itemsPerPage.Value * getPage.Value).Take(itemsPerPage.Value);
            }

            return products;
        }

        //[Authorize] -- to use this attribute, we must implement basic authentication, or forms authentication, or windows authentication
        [HttpPost]
        public void Post(List<ProductDto> products)
        {
            _dataAccess.SaveProducts(products);
        }
    }
}
