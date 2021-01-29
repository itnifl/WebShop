using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects;
using WebShop.DataAccess.Repositories.Interfaces;

namespace WebShop.DataAccess.Repositories.Repos
{
    public class OrderDataAccess : IOrderDataAccess
    {
        public void CheckoutOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public List<OrderDto> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void SaveOrders(List<OrderDto> orders)
        {
            throw new NotImplementedException();
        }
    }
}
