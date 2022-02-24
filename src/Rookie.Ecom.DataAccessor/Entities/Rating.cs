using System;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Rating : BaseEntity
    {
        [StringLength(maximumLength: 50)]
        public decimal Star { get; set; }

        [StringLength(maximumLength: 100)]
        public string Comment { get; set; }

        
        public Product Product { get; set; }

        

        public User User { get; set; }
    }
}
