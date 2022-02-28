using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{


    public class CartDto 
    {
        public Guid? Id { get; set; }
        public string CartName { get; set; }

        public UserDto User { get; set; }

        public ICollection<CartItemDto> CartItem { get; set; }
    }
}
