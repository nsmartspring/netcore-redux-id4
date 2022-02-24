using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
    

    public class CartItemDto 
    {

        public decimal Quantity { get; set; }

        
        public CartDto Cart { get; set; }
        public ProductDto Product { get; set; }
    }
    
}
