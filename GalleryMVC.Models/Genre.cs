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

        [Required]
        [DisplayName("Created Date")]
        public required DateTime CreatedDate { get; set; }

        [Required]
        [DisplayName("Last Edited Date")]
        public required DateTime LastEditedDate { get; set; }
    }
}