using GalleryMVC.DataAccess.Data;
using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;

namespace GalleryMVC.DataAccess.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private ApplicationDbContext _db;

        public GenreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public override void Add(Genre genre)
        {
            genre.Id = Guid.NewGuid();
            genre.CreatedDate = DateTime.UtcNow;
            genre.LastEditedDate = DateTime.UtcNow;
            base.Add(genre);
        }

        public void Update(Genre obj)
        {
            var genre = _db.Genres.FirstOrDefault(x => x.Id == obj.Id);
            if (genre != null)
            {
                genre.Name = obj.Name;
                genre.LastEditedDate = DateTime.UtcNow;
                _db.Genres.Update(genre);
            }
        }
    }
}