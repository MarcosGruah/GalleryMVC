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
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [DisplayName("Last Edited Date")]
        public DateTime LastEditedDate { get; set; }
    }
}