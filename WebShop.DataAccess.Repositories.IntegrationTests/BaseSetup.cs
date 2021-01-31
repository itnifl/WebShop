using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using WebShop.DataAccess.Repositories.Interfaces;
using WebShop.DataAccess.Repositories.Repos;

namespace WebShop.DataAccess.Repositories.IntegrationTests
{
    public class BaseSetup
    {
        protected ServiceProvider ServiceProvider;
        protected ServiceCollection ServiceCollection;
        protected IConfigurationRoot Configuration;

        [SetUp]
        public void Setup()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();


            ServiceCollection = new ServiceCollection();

            string mySqlConnectionStr = Configuration.GetConnectionString("DbConnectionString");
            ServiceCollection.AddDbContext<ProductDatabaseContext.ProductDatabaseContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

            ServiceCollection.AddLogging();
            ServiceCollection.AddTransient<ProductDatabaseContext.ProductDatabaseContext, ProductDatabaseContext.ProductDatabaseContext>();
            ServiceCollection.AddTransient<INewsDataAccess, NewsDataAccess>();
            ServiceCollection.AddTransient<IOrderDataAccess, OrderDataAccess>();
            ServiceCollection.AddTransient<IProductDataAccess, ProductDataAccess>();

            ServiceProvider = ServiceCollection.BuildServiceProvider();
        }
    }
}
