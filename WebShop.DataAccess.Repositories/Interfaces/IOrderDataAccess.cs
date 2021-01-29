using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.ProductDatabaseContext.Entities;

namespace WebShop.DataAccess.Repositories.Interfaces
{
    public interface IOrderDataAccess
    {
        List<OrderDto> GetOrders();
        void SaveOrders(List<OrderDto> orders);
        void CheckoutOrder(Guid orderId);
    }
}
