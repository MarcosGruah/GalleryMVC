using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;
using GalleryMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            GameVM gameVM = new()
            {
                GenreList = _unityOfWork.Genre
                .GetAll().OrderBy(genre => genre.Name)
                .Select(obj => new SelectListItem
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                }),
                Game = new Game()
            };

            return View(gameVM);
        }

        [HttpPost]
        public IActionResult Create(GameVM gameVM)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Game.Add(gameVM.Game);
                _unityOfWork.Save();
                TempData["success"] = "Game successfully created.";
                return RedirectToAction("Index");
            }
            else
            {
                gameVM.GenreList = _unityOfWork.Genre
                .GetAll().OrderBy(genre => genre.Name)
                .Select(obj => new SelectListItem
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
                return View(gameVM);
            }
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