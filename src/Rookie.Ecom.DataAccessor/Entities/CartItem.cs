using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("CartItem")]

    public class CartItem : BaseEntity
    {

        public decimal Quantity { get; set; }

       

        public Cart Cart { get; set; }


        public Product Product { get; set; }
    }
    
}
