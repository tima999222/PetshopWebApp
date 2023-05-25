using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace PetshopWebApp.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [DisallowNull]
        [MaxLength(100)]
        public string? CategoryName { get; set; }

        public ICollection<Products>? Products { get; set; }
    }
}
