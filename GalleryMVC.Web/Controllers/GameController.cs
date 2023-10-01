using GalleryMVC.Web.Data;
using GalleryMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GalleryMVC.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GameController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Game> objGameList = _db.Games.OrderBy(game => game.Name).ToList();
            return View(objGameList);
        }
    }
}