using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.Repositories.Interfaces;
using WebShop.DataAccess.Repositories.Repos;

namespace WebShop.DataAccess.Repositories.IntegrationTests
{
    public class NewsDataAccessTests : BaseSetup
    {
        private INewsDataAccess _dataAccess;
        [SetUp]
        public void Setup()
        {
            _dataAccess = new NewsDataAccess();
        }

        [Test]
        public void ICanSaveAndReadNews()
        {
            //Arrange
            var header = "Good weather";
            var article = "Good weather is reported south of Oslo";
            var dto = new NewsDto(header, article);
            //Assign
            _dataAccess.SaveNews(new List<NewsDto> { dto });
            //Assert
            var allNews = _dataAccess.GetNews();
            Assert.True(allNews.Any(x => x.Header == header && x.Article == article));
        }
    }
}