using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
   

    public class ProductImageDto 
    {
        
        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }

       
        public ProductDto Product { get; set; }

       
    }
}
