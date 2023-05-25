using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PetshopWebApp.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisallowNull]
        public string? ProductName { get; set; }

        [Required]
        [DisallowNull]
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }

        [Required]
        [DisallowNull]
        public int Price { get; set; }


        public Categories? Categories { get; set; }
    }
}
