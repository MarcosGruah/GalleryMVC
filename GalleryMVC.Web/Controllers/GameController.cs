using Microsoft.AspNetCore.Mvc;

namespace GalleryMVC.Web.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
