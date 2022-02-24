using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Order")]

    public class Order : BaseEntity
    {
        [StringLength(maximumLength: 50)]
        public string OrderName { get; set; }

        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    

        public User User { get; set; }




    }
}
