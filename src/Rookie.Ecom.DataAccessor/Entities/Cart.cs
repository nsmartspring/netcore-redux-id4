using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Cart")]

    public class Cart : BaseEntity
    {

        public string CartName { get; set; }

        public User User { get; set; }

        public IList<CartItem> CartItem { get; set; }
    }
}
