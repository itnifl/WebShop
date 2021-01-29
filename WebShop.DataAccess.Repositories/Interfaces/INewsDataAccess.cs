using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;

namespace WebShop.DataAccess.Repositories.Interfaces
{
    public interface INewsDataAccess
    {
        List<NewsDto> GetNews();
        void SaveNews(List<NewsDto> news);
    }
}
