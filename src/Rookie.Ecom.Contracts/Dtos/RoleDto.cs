using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
    

    public class RoleDto 
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string RoleName { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }

     

        public UserDto User { get; set; }
       
    }
}
