using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GalleryMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;

        public GenreController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public IActionResult Index()
        {
            List<Genre> objGenreList = _unityOfWork.Genre.GetAll().OrderBy(genre => genre.Name).ToList();
            return View(objGenreList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre obj)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Genre.Add(obj);
                _unityOfWork.Save();
                TempData["success"] = "Genre successfully created.";
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

            Genre? genreFromDb = _unityOfWork.Genre.Get(obj => obj.Id == guid);

            if (genreFromDb == null)
            {
                return NotFound();
            }

            return View(genreFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Genre obj)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Genre.Update(obj);
                _unityOfWork.Save();
                TempData["success"] = "Genre successfully edited.";
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

            Genre? genreFromDb = _unityOfWork.Genre.Get(obj => obj.Id == guid);

            if (genreFromDb == null)
            {
                return NotFound();
            }
            return View(genreFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(string? id)
        {
            if (id.IsNullOrEmpty() || !Guid.TryParse(id, out Guid guid))
            {
                return NotFound();
            }
            Genre? obj = _unityOfWork.Genre.Get(obj => obj.Id == guid);

            if (obj == null)
            {
                return NotFound();
            }

            _unityOfWork.Genre.Remove(obj);
            _unityOfWork.Save();
            TempData["success"] = "Genre successfully deleted.";
            return RedirectToAction("Index");
        }
    }
}