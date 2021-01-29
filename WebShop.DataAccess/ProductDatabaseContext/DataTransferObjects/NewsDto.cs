using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.Entities;

namespace WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects
{
    public class NewsDto
    {
        public NewsDto(string header, string article)
        {
            this.Header = header;
            this.Article = article;
        }

        public NewsDto(News news)
        {
            this.NewsId = news.NewsId;
            this.Header = news.Header;
            this.Article = news.Article;
        }
        public Guid NewsId { get; set; }

        public string Header { get; set; }
        public string Article { get; set; }
    }
}
