using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GalleryMVC.Models.ViewModels
{
    public class GameVM
    {
        public Game Game { get; set; } = new Game();

        [ValidateNever]
        public IEnumerable<SelectListItem> GenreList { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}