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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game obj)
        {
            if (obj.Name != null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is not a valid name.");
            }
            if (ModelState.IsValid)
            {
                obj.GameId = Guid.NewGuid();
                _db.Games.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}