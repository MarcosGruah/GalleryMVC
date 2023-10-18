using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GalleryMVC.Models
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Genre")]
        public required string Name { get; set; }
    }
}