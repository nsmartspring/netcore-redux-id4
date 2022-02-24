using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Role")]

    public class Role : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string RoleName { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }

        

        public User User { get; set; }
       
    }
}
