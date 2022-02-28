using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
   

    public class ProductImageDto 
    {
        public Guid? Id { get; set; }
        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }

       
        public ProductDto Product { get; set; }

       
    }
}
