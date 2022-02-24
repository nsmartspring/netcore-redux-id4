using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{


    public class CartDto 
    {


        public UserDto User { get; set; }

        public ICollection<CartItemDto> CartItem { get; set; }
    }
}
