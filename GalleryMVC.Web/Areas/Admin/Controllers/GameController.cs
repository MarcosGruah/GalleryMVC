using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GalleryMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GameController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;

        public GameController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public IActionResult Index()
        {
            List<Game> objGameList = _unityOfWork.Game.GetAll().OrderBy(game => game.Name).ToList();
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
                _unityOfWork.Game.Add(obj);
                _unityOfWork.Save();
                TempData["success"] = "Game successfully created.";
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

            Game? gameFromDb = _unityOfWork.Game.Get(obj => obj.GameId == guid);

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
                _unityOfWork.Game.Update(obj);
                _unityOfWork.Save();
                TempData["success"] = "Game successfully edited.";
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

            Game? gameFromDb = _unityOfWork.Game.Get(obj => obj.GameId == guid);

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
            Game? obj = _unityOfWork.Game.Get(obj => obj.GameId == guid);

            if (obj == null)
            {
                Console.WriteLine($"\"{id}\" is a valid Guid, but was not found in the DB.");
                return NotFound();
            }

            _unityOfWork.Game.Remove(obj);
            Console.WriteLine($"ID: {obj.GameId}\nName: {obj.Name}\nHas been removed from the Database.");
            _unityOfWork.Save();
            TempData["success"] = "Game successfully deleted.";
            return RedirectToAction("Index");
        }
    }
}