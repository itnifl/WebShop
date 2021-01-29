using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.Repositories.Interfaces;

namespace WebShop.DataAccess.Repositories.Repos
{
    public class NewsDataAccess : INewsDataAccess
    {
        public List<NewsDto> GetNews()
        {
            throw new NotImplementedException();
        }

        public void SaveNews(List<NewsDto> news)
        {
            throw new NotImplementedException();
        }
    }
}
