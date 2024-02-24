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
        [Required(ErrorMessage = "Please select a category")]
        public int? CategoryId { get; set; }
        public Categories? Categories { get; set; }

        [Required(ErrorMessage = "Please enter the movie title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the year the movie was created")]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be 1888 or higher")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please indicate whether the movie was edited or not")]
        public int Edited { get; set; }
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Please indicate whether the movie was copied to Plex or not")]
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}