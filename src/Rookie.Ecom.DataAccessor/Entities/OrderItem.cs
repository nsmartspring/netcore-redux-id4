using System;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class OrderItem : BaseEntity
    {

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
        
       

        public Order Order { get; set; }

      

        public Product Product { get; set; }
    }
}
