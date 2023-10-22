using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GalleryMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Genre> objGenreList = _unitOfWork.Genre.GetAll().OrderBy(genre => genre.Name).ToList();
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
                _unitOfWork.Genre.Add(obj);
                _unitOfWork.Save();
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

            Genre? genreFromDb = _unitOfWork.Genre.Get(obj => obj.Id == guid);

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
                _unitOfWork.Genre.Update(obj);
                _unitOfWork.Save();
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

            Genre? genreFromDb = _unitOfWork.Genre.Get(obj => obj.Id == guid);

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
            Genre? obj = _unitOfWork.Genre.Get(obj => obj.Id == guid);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Genre.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Genre successfully deleted.";
            return RedirectToAction("Index");
        }
    }
}