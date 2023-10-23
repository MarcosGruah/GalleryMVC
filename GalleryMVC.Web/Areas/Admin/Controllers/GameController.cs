using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;
using GalleryMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GalleryMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GameController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GameController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Game> objGameList = _unitOfWork.Game.GetAll(includeProperties: "Genre").OrderBy(game => game.Title).ToList();
            return View(objGameList);
        }

        public IActionResult Upsert(string? id)
        {
            GameVM gameVM = new()
            {
                GenreList = _unitOfWork.Genre
                .GetAll().OrderBy(genre => genre.Name)
                .Select(obj => new SelectListItem
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                }),
                Game = new Game()
            };

            if (string.IsNullOrEmpty(id))
            {
                //Create
                return View(gameVM);
            }
            else
            {
                //Update

                Guid.TryParse(id, out Guid validId);

                var gameFetch = _unitOfWork.Game.Get(obj => obj.Id == validId);

                if (gameFetch != null)
                {
                    gameVM.Game = gameFetch;
                }

                return View(gameVM);
            }
        }

        [HttpPost]
        public IActionResult Upsert(GameVM gameVM)
        {
            if (ModelState.IsValid)
            {
                if (gameVM.Game.Id == Guid.Empty)
                {
                    _unitOfWork.Game.Add(gameVM.Game);
                }
                else
                {
                    _unitOfWork.Game.Update(gameVM.Game);
                }
                _unitOfWork.Save();
                TempData["success"] = "Game successfully created.";
                return RedirectToAction("Index");
            }
            else
            {
                gameVM.GenreList = _unitOfWork.Genre
                .GetAll().OrderBy(genre => genre.Name)
                .Select(obj => new SelectListItem
                {
                    Text = obj.Name,
                    Value = obj.Id.ToString()
                });
                return View(gameVM);
            }
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Game> objGameList = _unitOfWork.Game.GetAll(includeProperties: "Genre").OrderBy(game => game.Title).ToList();
            return Json(new { data = objGameList });
        }

        [HttpDelete]
        public IActionResult Delete(Guid? id)
        {
            var game = _unitOfWork.Game.Get(u => u.Id == id);

            if (game == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Game.Remove(game);
            _unitOfWork.Save();

            List<Game> objGameList = _unitOfWork.Game.GetAll(includeProperties: "Genre").OrderBy(game => game.Title).ToList();
            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion API CALLS
    }
}