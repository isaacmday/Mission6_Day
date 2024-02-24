using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Day.Models
{
    // create the object that the database will store
    public class App
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("Categories")]
        public int? CategoryId { get; set; }
        public Categories Categories { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public string? Director { get; set; }

        [Required]
        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}