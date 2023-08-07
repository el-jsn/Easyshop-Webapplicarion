namespace Easyshop.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DeliveryRadius { get; set; }

        // Navigation properties
        public List<Product> Products { get; set; }
    }


}
