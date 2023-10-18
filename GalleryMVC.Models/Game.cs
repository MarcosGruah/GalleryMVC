using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GalleryMVC.Models
{
    public class Game
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The Game Name must be between 3 and 30 characters.")]
        [DisplayName("Game Name")]
        public required string Title { get; set; }

        [Required]
        [DisplayName("Publisher")]
        public required string Publisher { get; set; }

        [Required]
        [DisplayName("Developer")]
        public required string Developer { get; set; }

        [Required]
        [DisplayName("Price")]
        [Range(0, 1000, ErrorMessage = "Price must be between $0 and $1000.")]
        public required decimal Price { get; set; }

        [Required]
        [DisplayName("Created Date")]
        public required DateTime CreatedDate { get; set; }

        [Required]
        [DisplayName("Last Edited Date")]
        public required DateTime LastEditedDate { get; set; }
    }
}