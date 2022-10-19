using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovieRanker.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("MovieName")]
        public string Name { get; set; }
        public string? Genre { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        public string? Studio { get; set; }
        [Required]
        public int Score { get; set; }


    }
}
