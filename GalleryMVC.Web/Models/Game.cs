using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GalleryMVC.Web.Models
{
    public class Game
    {
        [Key]
        public Guid GameId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3,ErrorMessage = "The Game Name must be between 3 and 30 characters.")]
        [DisplayName("Game Name")]
        public required string Name { get; set; }
    }
}