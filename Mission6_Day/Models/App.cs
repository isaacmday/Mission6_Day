using System.ComponentModel.DataAnnotations;

namespace Mission6_Day.Models
{
    // create the object that the database will store
    public class App
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public required string Category { get; set; }

        [Required]
        public required string Subcategory { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required int Year { get; set; }

        [Required]
        public required string Director { get; set; }

        [Required]
        public required string Rating { get; set; }
        public string? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
