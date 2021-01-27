using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Commons;
using WebShop.DataAccess.ProductDatabaseContext.Entities;

namespace WebShop.DataAccess.ProductDatabaseContext.DataTransferObjects
{
    public class UserDto
    {
        public UserDto(User user)
        {
            this.UserId = user.UserId;
            this.Name = user.Name;
            this.AccessRole = user.AccessRole;

            Orders = new List<OrderDto>();
            foreach (var efOrder in user.Orders)
            {
                Orders.Add(new OrderDto(efOrder));
            }
        }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public AccessRole AccessRole { get; set; }
        public List<OrderDto> Orders { get; set; }
    }
}


