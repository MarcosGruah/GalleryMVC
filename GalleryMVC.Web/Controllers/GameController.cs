using GalleryMVC.Web.Data;
using GalleryMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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

        public IActionResult Edit(string? id)
        {
            if (id.IsNullOrEmpty() || !Guid.TryParse(id, out Guid guid))
            {
                Console.WriteLine($"\"{id}\" is not a valid ID.");
                return NotFound();
            }

            Game? gameFromDb = _db.Games.Find(guid);

            if (gameFromDb == null)
            {
                Console.WriteLine($"\"{id}\" is a valid Guid, but was not found in the DB.");
                return NotFound();
            }
            return View(gameFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Game obj)
        {
            if (ModelState.IsValid)
            {
                _db.Games.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(string? id)
        {
            if (id.IsNullOrEmpty() || !Guid.TryParse(id, out Guid guid))
            {
                Console.WriteLine($"\"{id}\" is not a valid ID.");
                return NotFound();
            }

            Game? gameFromDb = _db.Games.Find(guid);

            if (gameFromDb == null)
            {
                Console.WriteLine($"\"{id}\" is a valid Guid, but was not found in the DB.");
                return NotFound();
            }
            return View(gameFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(string? id)
        {
            if (id.IsNullOrEmpty() || !Guid.TryParse(id, out Guid guid))
            {
                Console.WriteLine($"\"{id}\" is not a valid ID.");
                return NotFound();
            }
            Game? obj = _db.Games.Find(guid);

            if (obj == null)
            {
                Console.WriteLine($"\"{id}\" is a valid Guid, but was not found in the DB.");
                return NotFound();
            }

            _db.Games.Remove(obj);
            Console.WriteLine($"ID: {obj.GameId}\nName: {obj.Name}\nHas been removed from the Database.");
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}