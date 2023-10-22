using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalleryMVC.Models
{
    public class Game
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The Game Name must be between 3 and 30 characters.")]
        [DisplayName("Game Name")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [DisplayName("Publisher")]
        public string Publisher { get; set; } = string.Empty;

        [Required]
        [DisplayName("Developer")]
        public string Developer { get; set; } = string.Empty;

        [Required]
        [DisplayName("Price")]
        [Range(0, 1000, ErrorMessage = "Price must be between $0 and $1000.")]
        public decimal Price { get; set; }

        [DisplayName("Genre")]
        public Guid GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }

        [Required]
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [DisplayName("Last Edited Date")]
        public DateTime LastEditedDate { get; set; }
    }
}