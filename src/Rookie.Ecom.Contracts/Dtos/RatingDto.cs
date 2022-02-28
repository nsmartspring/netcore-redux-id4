using System;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class RatingDto 
    {
        public Guid? Id { get; set; }
        public decimal Star { get; set; }

        [StringLength(maximumLength: 100)]
        public string Comment { get; set; }


        public ProductDto Product { get; set; }

        
        public UserDto User { get; set; }
    }
}
