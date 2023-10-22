using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;
using GalleryMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using System;

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
            List<Game> objGameList = _unitOfWork.Game.GetAll().OrderBy(game => game.Title).ToList();
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

                gameVM.Game = _unitOfWork.Game.Get(obj => obj.Id == validId);

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

        public IActionResult Delete(string? id)
        {
            if (id.IsNullOrEmpty() || !Guid.TryParse(id, out Guid guid))
            {
                return NotFound();
            }

            Game? gameFromDb = _unitOfWork.Game.Get(obj => obj.Id == guid);

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
            Game? obj = _unitOfWork.Game.Get(obj => obj.Id == guid);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Game.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Game successfully deleted.";
            return RedirectToAction("Index");
        }
    }
}