using System.ComponentModel.DataAnnotations;

namespace Mission6_Day.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public required string Category { get; set; }
    }
}
