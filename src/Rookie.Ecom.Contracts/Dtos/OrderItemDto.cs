using System;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class OrderItemDto 
    {

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
        

        public OrderDto Order { get; set; }

     

        public ProductDto Product { get; set; }
    }
}
