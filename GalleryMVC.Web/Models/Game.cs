using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GalleryMVC.Web.Models
{
    public class Game
    {
        [Key]
        public Guid GameId { get; set; }

        [Required]
        [DisplayName("Game Name")]
        public string Name { get; set; } = "";
    }
}