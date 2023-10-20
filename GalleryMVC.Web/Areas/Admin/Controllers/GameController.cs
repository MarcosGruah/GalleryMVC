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
            List<Game> objGameList = _unityOfWork.Game.GetAll().OrderBy(game => game.Title).ToList();
            return View(objGameList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game obj)
        {
            if (ModelState.IsValid)
            {
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
                return NotFound();
            }

            Game? gameFromDb = _unityOfWork.Game.Get(obj => obj.Id == guid);

            if (gameFromDb == null)
            {
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
                return NotFound();
            }

            Game? gameFromDb = _unityOfWork.Game.Get(obj => obj.Id == guid);

            if (gameFromDb == null)
            {
                return NotFound();
            }
            return View(gameFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(string? id)
        {
            if (id.IsNullOrEmpty() || !Guid.TryParse(id, out Guid guid))
            {
                return NotFound();
            }
            Game? obj = _unityOfWork.Game.Get(obj => obj.Id == guid);

            if (obj == null)
            {
                return NotFound();
            }

            _unityOfWork.Game.Remove(obj);
            _unityOfWork.Save();
            TempData["success"] = "Game successfully deleted.";
            return RedirectToAction("Index");
        }
    }
}