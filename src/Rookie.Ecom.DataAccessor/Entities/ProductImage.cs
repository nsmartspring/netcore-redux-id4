using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("ProductImage")]

    public class ProductImage : BaseEntity
    {
        
        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }

        public Guid? ProductId { get; set; }

        public Product Product { get; set; }

       
    }
}
